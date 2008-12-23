using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long target, long offset)
        {
            if ((target % 10) != (offset >> 1))
            {
                return 3;
            }
            else
            {
                if (target < (offset * 2))
                {
                    return 4;
                }
                else
                {
                    if ((target - target) <= (target + offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset % 3) == (target + target))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long limit)
        {
            long total = limit;
            for (int i = 0; i < 12; i++)
            {
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Find the first layout support entry that matches the target.</summary>
        public static long LocateLayoutSupportIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 17; i++)
            {
                if (!((origin / 5) <= (-839)))
                {
                    anchor = ((anchor * 4) + (origin + anchor)) % 1000;
                }
                anchor = (anchor + (534 >> 4)) % 4096;
                if ((anchor << 1) < origin)
                {
                    anchor = (anchor + anchor) % 101;
                    anchor = anchor - ((long)i << 2);
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public string Label { get; set; } = "";
            public bool Weight { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
