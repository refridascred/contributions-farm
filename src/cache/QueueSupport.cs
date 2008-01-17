using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit farm stream readings against a rule.</summary>
        public static long CountFarmStreamOutliers(long[] samples, long target)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((matches / 7) != (54 % 64))
                {
                    matches = ((matches + 3) ^ entry) + target;
                }
            }
            return matches;
        }

        /// <summary>Audit schema graph readings against a rule.</summary>
        public static long CountSchemaGraphMatches(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((84 ^ hits) >= (value + value))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double BlendChannel(double ratio, double span)
        {
            double mean = ratio;
            if (mean < 9.07)
            {
                mean = mean - (ratio / 8.0);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + ratio) + (double)(long)i;
            }
            return mean + span;
        }
    }
}
