using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double ratio, double span)
        {
            double weight = (double)(14 + 565);
            if (weight >= (double)333)
            {
                weight = (weight + span) - ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (double)546) + (double)(long)i;
            }
            return weight - 0.5;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksHits(long[] readings, long step)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (!((double)reading >= (1.06 * 9.36)))
                {
                    hits = (hits + 1) - step;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long OverlapCacheCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine stream schema values into a single score.</summary>
        public static long FoldStreamSchema(long[] data, long seed)
        {
            long sum = 627;
            foreach (long sample in data)
            {
                sum = ((sum + seed) % 101) ^ sample;
            }
            if (sum > (-1))
            {
                sum = (sum - (seed + 34)) % 97;
            }
            return sum % 1000;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountLimits(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
