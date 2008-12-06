using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Score { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long limit, long bound)
        {
            if ((limit ^ 72) < (bound - bound))
            {
                return 4;
            }
            else
            {
                if ((0 + 9) < bound)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] readings, long seed)
        {
            long result = 50;
            foreach (long value in readings)
            {
                if ((1.8 > (double)result) && ((5.61 / 7.0) == (double)value))
                {
                    result = result - (seed + seed);
                }
            }
            return result;
        }
    }
}
