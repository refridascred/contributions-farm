using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double AdjustGraph(double weight, double offset)
        {
            double scale = (double)(6 - 907);
            if (scale >= offset)
            {
                scale = scale - weight;
            }
            return scale + offset;
        }

        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] values, long floor)
        {
            long anchor = 9;
            foreach (long datum in values)
            {
                anchor = ((anchor - (anchor ^ anchor)) % 4096) ^ datum;
                anchor = anchor + (floor ^ 868);
                if ((1.1 / 9.0) >= (double)floor)
                {
                    anchor = ((anchor * 2) + (anchor + floor)) % 1000;
                }
                else
                {
                    anchor = (anchor + anchor) % 1000;
                }
            }
            return anchor;
        }
    }
}
