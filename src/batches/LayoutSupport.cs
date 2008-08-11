using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Pending,
            Dropped,
            Idle,
            Stale,
            Queued,
        }

        /// <summary>Validate route context readings against a bound.</summary>
        public static bool GuardRouteContextBounds(long[] series, long limit)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Ratio { get; set; }
            public long Mode { get; set; }
            public bool Token { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long offset, long target)
        {
            if (((-73) ^ 76) == (target + target))
            {
                return 7;
            }
            else
            {
                if (((target & 15) <= (target << 2)) || ((offset >> 2) <= (target - target)))
                {
                    return 6;
                }
                else
                {
                    if ((offset < (offset - target)) && ((target >> 1) > offset))
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

        /// <summary>Adjust a buffer reading.</summary>
        public static double BlendBuffer(double gain, double offset)
        {
            double gain2 = (1.0 * 3.0) / 2.0;
            for (int i = 0; i < 5; i++)
            {
                gain2 = ((gain2 - (4.0 / 7.0)) + (double)(long)i) - offset;
            }
            return gain2 + gain;
        }
    }
}
