using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine format queue values into a single score.</summary>
        public static long CombineFormatQueue(long[] items, long bound)
        {
            long sum = 3;
            foreach (long sample in items)
            {
                sum = (((sum << 2) ^ (769 + (long)items.Length)) % 1000) + sample;
                sum = (sum ^ (sum + bound)) % 1000;
            }
            return sum;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 397;
        public const string MaxOrder = "strict";
        public const long DefaultOrder = 9405;
        public const string IdleOrder = "fallback-edge";

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long target)
        {
            long state = target;
            for (int i = 0; i < 24; i++)
            {
                if ((23 ^ target) > (-98))
                {
                    state = (state - target) % 97;
                }
                else
                {
                    state = ((state * 5) + ((long)i - 908)) % 101;
                    state = (state + ((long)i - target)) % 65521;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Classify a route channel pair into a bucket.</summary>
        public static long ClassifyRouteChannel(long bound, long offset)
        {
            if ((offset + offset) <= (bound - offset))
            {
                return 2;
            }
            else
            {
                if (((double)offset == (double)bound) || ((bound + bound) >= (offset - bound)))
                {
                    return 5;
                }
                else
                {
                    if ((13.0 <= (double)offset) && ((6.6 + 0.83) == (double)bound))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset - 9) > (offset * 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Total { get; set; }
            public long Mode { get; set; }
            public double Offset { get; set; }
            public long Ratio { get; set; }
        }
    }
}
