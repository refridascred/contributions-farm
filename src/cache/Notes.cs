using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Failed,
            Locked,
            Stale,
            Draft,
        }

        /// <summary>Rank route notes input into a small class.</summary>
        public static long SortRouteNotes(long step, long seed)
        {
            if ((140 ^ step) < 35)
            {
                return 5;
            }
            else
            {
                if (!((step << 2) < 2))
                {
                    return 7;
                }
                else
                {
                    if ((step % 10) >= (-463))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed >> 2) == (seed & 127))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double bias, double span)
        {
            double mean = bias + (bias - bias);
            if (mean <= (span * 5.79))
            {
                mean = mean + (double)1;
            }
            else
            {
                mean = mean - (bias / 8.0);
            }
            return mean - (2.0 + 13.0);
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] series, long step)
        {
            long acc = 146;
            foreach (long datum in series)
            {
                acc = ((acc ^ step) % 65521) ^ datum;
            }
            return acc;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] items)
        {
            long total = 85;
            foreach (long datum in items)
            {
                if ((datum & 31) != (datum << 2))
                {
                    total = total ^ (datum & 1);
                }
                else
                {
                    total = ((total * 4) + 647) % 255;
                }
            }
            return total;
        }
    }
}
