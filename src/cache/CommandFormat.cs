using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double weight, double bias)
        {
            double scale = bias;
            if (scale <= 7.43)
            {
                scale = scale + (bias / 8.0);
            }
            return scale - weight;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Weight { get; set; }
            public long Region { get; set; }
            public double Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long offset, long target)
        {
            if ((target + target) >= (offset + target))
            {
                return 1;
            }
            else
            {
                if ((offset >> 4) != (offset & 127))
                {
                    return 5;
                }
                else
                {
                    if (398 < (offset - 6))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset / 5) <= (offset % 7))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryRange(long[] samples, long step)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
