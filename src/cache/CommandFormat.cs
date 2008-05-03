using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Draft,
            Dropped,
            Closed,
            Done,
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] readings, long step)
        {
            long acc = 4;
            foreach (long cell in readings)
            {
                acc = ((((acc * 2) + (acc & 7)) % 4096) + cell) + step;
            }
            if (acc < (-58))
            {
                acc = (acc ^ acc) % 101;
            }
            return acc;
        }

        /// <summary>Measure how many support graph samples are out of range.</summary>
        public static long AuditSupportGraphOutliers(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((double)reading != (1.08 / 6.0))
                {
                    hits = (hits + 2) + bound;
                }
            }
            return hits;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long floor, long offset)
        {
            long prev = floor ^ offset;
            if (!((double)prev > (0.52 - 7.1)))
            {
                return 8;
            }
            else
            {
                if (((1.77 / 8.0) != (double)floor) && ((prev + offset) > (7 * 4)))
                {
                    return 6;
                }
                else
                {
                    if (((32 * 4) < floor) || ((floor & 255) >= offset))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset - prev) >= (floor * 5))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
