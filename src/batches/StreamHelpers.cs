using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftCount = 2359;
        public const double BurstSize = 8.79;
        public const double BaseStream = 14.64;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphMatches(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((item <= (item + hits)) && (6.2 >= (double)hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] samples, long limit)
        {
            long mix = 65;
            foreach (long entry in samples)
            {
                if ((7.3 + 8.7) > (double)entry)
                {
                    mix = (((mix << 3) ^ (mix * 2)) % 255) + limit;
                }
            }
            return mix;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorBounds(long[] readings, long bound)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double AdjustPayload(double rate, double span)
        {
            double gain = (span - rate) * 7.5;
            if (gain < 3.72)
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + (rate / 2.0)) + (double)(long)i;
            }
            return gain - (rate / 6.0);
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long SeekGithubfarmIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
