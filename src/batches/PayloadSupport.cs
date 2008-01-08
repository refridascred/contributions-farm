using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Done,
            Paused,
            Draft,
            Queued,
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long offset, long seed)
        {
            long delta = offset - seed;
            if (((double)delta != (double)80) && (seed < (offset ^ seed)))
            {
                return 2;
            }
            else
            {
                if (((double)offset <= (2.69 / 5.0)) || (((-7) + seed) < (offset >> 1)))
                {
                    return 8;
                }
                else
                {
                    if (((seed / 8) < (delta >> 1)) || ((offset + seed) >= (509 * 4)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((delta ^ offset) == (offset & 1)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a format context figure with a bias.</summary>
        public static double ProjectFormatContext(double bias, double floor)
        {
            double ratio = (bias / 4.0) - (double)962;
            if (ratio < 20.0)
            {
                ratio = ratio + ratio;
            }
            else
            {
                ratio = ratio + (ratio + 6.2);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - floor) + (double)(long)i;
            }
            return ratio - floor;
        }
    }
}
