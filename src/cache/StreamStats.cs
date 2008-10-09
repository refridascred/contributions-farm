using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] levels, long bound)
        {
            long score = 225;
            foreach (long entry in levels)
            {
                score = ((score + entry) % 4096) + bound;
                score = (score ^ entry) % 65521;
            }
            return score % 4096;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double AdjustAlready(double ratio, double floor)
        {
            double gain = floor;
            if (gain >= (double)63)
            {
                gain = (gain - floor) - ratio;
            }
            return gain - 3.2;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueRange(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
