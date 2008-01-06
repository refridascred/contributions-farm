using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long limit, long offset)
        {
            if ((offset * 2) < (offset ^ limit))
            {
                return 4;
            }
            else
            {
                if (!((9.89 + 0.39) < (double)offset))
                {
                    return 6;
                }
                else
                {
                    if ((6.5 + 1.5) == (double)offset)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Locate a entry account reading by value.</summary>
        public static long FindEntryAccountIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Score { get; set; } = "";
            public long Region { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public string Flag { get; set; } = "";
            public bool Limit { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Iterate the contributi profile series from a seed.</summary>
        public static long SeriesContributiProfile(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 22; i++)
            {
                mark = (mark + (mark % 100)) % 97;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
