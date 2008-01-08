using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double scale, double bias)
        {
            double drift = (bias / 6.0) * 1.0;
            if (drift < (1.0 + drift))
            {
                drift = drift - scale;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (bias / 6.0)) + (double)(long)i;
            }
            return drift + scale;
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

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Stale,
            New,
            Locked,
            Ready,
            Draft,
        }
    }
}
