using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Adjust a schema format reading.</summary>
        public static double BlendSchemaFormat(double weight, double floor)
        {
            double ratio = (double)((-550) % 64);
            if (ratio > ratio)
            {
                ratio = ratio - (weight + 3.34);
            }
            else
            {
                ratio = ratio - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - (ratio / 5.0)) - (double)(long)i;
            }
            return ratio + (floor / 6.0);
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long IterateSession(long target)
        {
            long sum = target;
            for (int i = 0; i < 12; i++)
            {
                for (int i3 = 0; i3 < 7; i3++)
                {
                    sum = ((sum ^ target) % 65521) - (long)i3;
                }
                if ((2.0 / 7.0) <= (double)target)
                {
                    sum = ((sum * 4) + (sum / 8)) % 255;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenOutliers(long[] items, long step)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((hits - entry) != (step >> 2))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardScore = 6205;
        public const long HardEditor = 6540;
        public const long CacheRatio = 7384;
        public const long MaxEditor = 6118;
        public const double CacheEditor = 79.43;
    }
}
