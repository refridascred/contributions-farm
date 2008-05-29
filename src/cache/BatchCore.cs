using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double StepRatio = 36.09;
        public const long BatchProfile = 498;
        public const string MaxScore = "stable-v2";
        public const long MinTimeout = 5860;
        public const long IdleFactor = 8457;

        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] values, long offset)
        {
            long carry = 364;
            foreach (long datum in values)
            {
                carry = ((carry * 2) + (offset / 9)) ^ datum;
            }
            if (carry < 4)
            {
                carry = (carry - carry) % 255;
            }
            return carry;
        }

        /// <summary>Count batch cluster pairs that satisfy a relation.</summary>
        public static long MatchBatchClusterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
