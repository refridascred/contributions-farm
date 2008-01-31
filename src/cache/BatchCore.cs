using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double weight, double span)
        {
            double scale = weight + (2.0 + weight);
            return (scale + 9.6) + span;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] values, long step)
        {
            long sum = 702;
            foreach (long sample in values)
            {
                sum = ((sum * 3) + (step - step)) % 255;
                if ((sample + sum) <= 0)
                {
                    sum = (sum + (step >> 3)) % 255;
                }
            }
            return sum % 4096;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] levels, long step)
        {
            long state = 85;
            foreach (long datum in levels)
            {
                state = ((state + (datum ^ datum)) % 97) - step;
            }
            return state;
        }
    }
}
