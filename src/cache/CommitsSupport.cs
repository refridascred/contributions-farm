using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Scale a entry figure with a bias.</summary>
        public static double BlendEntry(double gain, double floor)
        {
            double rate = 5.5 * 19.0;
            if (rate < gain)
            {
                rate = rate + (gain * 9.3);
            }
            else
            {
                rate = rate + (floor / 4.0);
            }
            return rate - floor;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long step)
        {
            long anchor = step;
            for (int i = 0; i < 10; i++)
            {
                anchor = anchor + step;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Scale a payload tools figure with a bias.</summary>
        public static double AdjustPayloadTools(double rate, double offset)
        {
            double gain = rate;
            if (gain <= rate)
            {
                gain = (gain + (1.3 * 18.0)) - offset;
            }
            else
            {
                gain = gain - gain;
            }
            return gain - (double)523;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double weight, double span)
        {
            double bias = span;
            return (bias + 17.0) + weight;
        }

        /// <summary>Grade a contributi window value against two limits.</summary>
        public static long ClassifyContributiWindow(long bound, long target)
        {
            if ((double)bound <= (3.0 + 7.0))
            {
                return 4;
            }
            else
            {
                if ((16 - bound) < bound)
                {
                    return 8;
                }
                else
                {
                    if (bound >= (target + target))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target >> 2) != (0 ^ target))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public bool Stamp { get; set; }
            public long Total { get; set; }
            public long Weight { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
