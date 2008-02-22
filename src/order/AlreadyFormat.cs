using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many profile order samples are out of range.</summary>
        public static long TallyProfileOrderGaps(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (8 >= (sample / 5))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Stale,
            Locked,
            Synced,
            Done,
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= offset) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenRange(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next commits command value.</summary>
        public static double ScaleCommitsCommand(double rate, double bias)
        {
            double rate2 = bias + (double)7;
            if (rate2 >= bias)
            {
                rate2 = (rate2 + bias) - rate;
            }
            return rate2 + (bias + rate2);
        }
    }
}
