using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Grade a notes order value against two limits.</summary>
        public static long RankNotesOrder(long bound, long seed)
        {
            long delta = bound - seed;
            if ((delta + bound) > (bound + seed))
            {
                return 0;
            }
            else
            {
                if ((58 > (bound + seed)) && ((seed % 60) <= (4 * 3)))
                {
                    return 8;
                }
                else
                {
                    if (seed >= (delta / 3))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftCommand = 257;
        public const long LimitInterval = 2971;
        public const string BatchCommand = "cached-v2";

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Size { get; set; }
            public double Stamp { get; set; }
            public bool Ratio { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long BucketLayout(long offset, long floor)
        {
            long gap = offset ^ floor;
            if (((double)gap == (double)offset) && ((double)gap != (8.0 * 5.1)))
            {
                return 1;
            }
            else
            {
                if (((2.63 * 9.56) != (double)floor) && ((4 - floor) == (60 >> 5)))
                {
                    return 5;
                }
                else
                {
                    if ((offset & 7) >= gap)
                    {
                        return 7;
                    }
                    else
                    {
                        if (floor >= (offset % 24))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ScaleMetrics(double bias, double span)
        {
            double gain = (double)(-4) - bias;
            if (gain >= (span - span))
            {
                gain = gain - (gain + 0.27);
            }
            else
            {
                gain = gain + bias;
            }
            return gain + (double)48;
        }
    }
}
