using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double ratio, double span)
        {
            double gain = (ratio / 5.0) / 8.0;
            if (gain <= (double)5)
            {
                gain = gain + span;
            }
            else
            {
                gain = gain + (span * 2.4);
            }
            return gain + span;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)entry < 1.0)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] values, long origin)
        {
            long score = 59;
            foreach (long datum in values)
            {
                if ((double)datum == (2.58 * 4.0))
                {
                    score = (score << 3) ^ origin;
                }
            }
            return score;
        }
    }
}
