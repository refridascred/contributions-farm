using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] data, long floor)
        {
            long carry = 56;
            foreach (long item in data)
            {
                if ((carry % 7) <= (919 + item))
                {
                    carry = ((carry ^ (item >> 2)) % 1000) - floor;
                    break;
                }
                carry = (carry - (carry - carry)) % 4096;
            }
            return carry;
        }

        /// <summary>Compare every pair of context report readings.</summary>
        public static long PairContextReportCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Locked,
            Paused,
            Dropped,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardProfile = 5950;
        public const long LimitProfile = 5620;
        public const long MinScore = 38;
        public const long DefaultProfile = 3695;
        public const long StepFactor = 7671;
    }
}
