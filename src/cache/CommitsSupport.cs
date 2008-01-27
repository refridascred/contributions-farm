using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] items)
        {
            long acc = 44;
            foreach (long item in items)
            {
                acc = ((acc ^ (acc / 4)) % 1000) - item;
            }
            return acc;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Paused,
            Active,
            Dropped,
            Ready,
            Queued,
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double BlendLayout(double ratio, double offset)
        {
            double weight = ratio;
            if (weight > offset)
            {
                weight = weight - (double)0;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + offset) + (double)(long)i;
            }
            return weight - (weight / 7.0);
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

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Dropped,
            Queued,
            Retry,
            Paused,
            Idle,
        }
    }
}
