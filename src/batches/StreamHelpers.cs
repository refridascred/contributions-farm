using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double BlendTools(double gain, double span)
        {
            double weight = 8.3;
            if (weight > (double)74)
            {
                weight = (weight - weight) + span;
            }
            else
            {
                weight = weight - gain;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (double)4) + (double)(long)i;
            }
            return weight - gain;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesGaps(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((2.55 + 8.0) <= (double)count)
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }

        /// <summary>Validate metrics counter readings against a bound.</summary>
        public static bool VerifyMetricsCounterBounds(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 2549;
        public const double BurstScore = 5.36;
        public const long HardSize = 745;
        public const double BatchChannel = 85.19;

        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < seed) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count stats layout pairs that satisfy a relation.</summary>
        public static long PairStatsLayoutCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
