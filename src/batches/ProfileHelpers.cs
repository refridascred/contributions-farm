using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long floor, long seed)
        {
            if (!(seed >= floor))
            {
                return 6;
            }
            else
            {
                if (floor < (seed * 4))
                {
                    return 2;
                }
                else
                {
                    if (((seed << 2) < (20 ^ seed)) && ((seed * 5) == (seed + floor)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed >> 4) < floor)
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
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 4; i++)
            {
                if ((((long)i >> 1) <= ((long)i % 24)) || ((double)limit != (5.8 - 2.67)))
                {
                    anchor = ((anchor << 2) ^ (long)i) % 101;
                    anchor = anchor ^ (anchor + anchor);
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] values, long step)
        {
            long anchor = -1;
            foreach (long reading in values)
            {
                anchor = (anchor - anchor) + reading;
                anchor = (anchor - anchor) % 65521;
            }
            if (anchor < 83)
            {
                anchor = anchor - (step & 15);
            }
            return anchor;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Paused,
            Synced,
            Ready,
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public double Flag { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public string Size { get; set; } = "";
            public double Weight { get; set; }
            public string Rank { get; set; } = "";
            public string Stamp { get; set; } = "";
        }
    }
}
