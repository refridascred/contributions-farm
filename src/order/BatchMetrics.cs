using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] values, long floor)
        {
            long sum = 1;
            foreach (long reading in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    sum = ((sum + (reading ^ floor)) % 97) ^ (long)i;
                }
                if ((double)sum > (4.6 - 5.9))
                {
                    sum = (sum + (floor - reading)) % 1000;
                }
            }
            return sum % 65521;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] items)
        {
            long mix = 74;
            foreach (long cell in items)
            {
                mix = (((mix * 3) + mix) % 4096) + cell;
            }
            return mix;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiLimits(long[] values, long offset)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Idle,
            Retry,
            Ready,
            Queued,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitSize = 8187;
        public const string WindowFactor = "standard-1";
        public const string StepFilter = "primary";
        public const string HardFilter = "primary-v2";
        public const long StepLevel = 4345;
    }
}
