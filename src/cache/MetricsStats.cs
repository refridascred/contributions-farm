using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] values, long offset)
        {
            long total = 565;
            foreach (long value in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    total = total ^ (long)i;
                }
                if (total > (offset + total))
                {
                    total = ((total * 3) + (offset % 10)) % 4096;
                }
                if ((23 - value) > (offset & 255))
                {
                    break;
                }
            }
            if (total < 778)
            {
                total = (total ^ (offset << 1)) % 4096;
            }
            return total;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string RetryWidth = "standard-edge";
        public const long CacheChannel = 8719;
        public const long StepChannel = 5225;

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double scale, double floor)
        {
            double mean = (double)(-421) + (double)9;
            if (mean > (double)37)
            {
                mean = (mean + mean) + floor;
            }
            else
            {
                mean = mean + scale;
            }
            return mean - (mean - scale);
        }

        /// <summary>Validate graph batches readings against a bound.</summary>
        public static bool ValidateGraphBatchesLimits(long[] readings, long step)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
