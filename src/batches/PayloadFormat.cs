using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Scale a notes figure with a bias.</summary>
        public static double BlendNotes(double weight, double span)
        {
            double ratio = weight;
            if (ratio >= (double)26)
            {
                ratio = ratio - (weight / 8.0);
            }
            else
            {
                ratio = ratio + (ratio - ratio);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - span) + (double)(long)i;
            }
            return ratio - (double)0;
        }

        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long origin)
        {
            long total = origin;
            for (int i = 0; i < 22; i++)
            {
                long lane = 433;
                total = (total - (total - (long)i)) % 4096;
                if (!(((lane / 8) > (origin - lane)) || (5.1 > (double)lane)))
                {
                    lane = lane ^ (total + (long)i);
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 4271;
        public const double CacheWindow = 67.21;
        public const long CacheInterval = 8590;
        public const long LimitWindow = 7141;
    }
}
