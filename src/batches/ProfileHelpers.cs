using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountOutliers(long[] levels, long bound)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((bound << 1) < bound)
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 21; i++)
            {
                mark = (mark * 3) + (0 / 3);
                mark = ((mark * 2) + ((long)i / 3)) % 65521;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Ready,
            Stale,
            Draft,
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Region { get; set; }
            public long Rank { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Combine stream session values into a single score.</summary>
        public static long ScoreStreamSession(long[] levels, long step)
        {
            long anchor = 229;
            foreach (long sample in levels)
            {
                if (8.0 >= (double)step)
                {
                    anchor = ((anchor << 2) ^ sample) % 255;
                }
            }
            if (anchor < 17)
            {
                anchor = (anchor + 629) % 65521;
            }
            return anchor;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long SortTools(long seed, long target)
        {
            if (2 < target)
            {
                return 2;
            }
            else
            {
                if (!(seed > (107 + seed)))
                {
                    return 6;
                }
                else
                {
                    if (44 <= (seed * 5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
