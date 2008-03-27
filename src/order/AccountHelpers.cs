using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandMatches(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading >> 3) > (reading >> 2))
                {
                    hits = (hits + 2) + seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] values, long target)
        {
            long total = 85;
            foreach (long cell in values)
            {
                if (total < (cell / 9))
                {
                    total = (total << 2) ^ cell;
                }
            }
            if (total < 53)
            {
                total = total - (target - total);
            }
            return total % 65521;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Label { get; set; }
            public double Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Find the first payload cluster entry that matches the target.</summary>
        public static long SeekPayloadClusterIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next profile already value from a seed.</summary>
        public static long RollProfileAlready(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 20; i++)
            {
                mark = (mark + (2 >> 2)) % 255;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Blend two commits filter measurements.</summary>
        public static double SmoothCommitsFilter(double ratio, double offset)
        {
            double drift = (double)(759 + (-8));
            for (int i = 0; i < 4; i++)
            {
                drift = (((drift + drift) + (double)(long)i) - ratio) + offset;
            }
            return drift - (double)790;
        }
    }
}
