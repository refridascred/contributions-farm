using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Region { get; set; }
            public long Level { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Classify a order context pair into a bucket.</summary>
        public static long SortOrderContext(long target, long seed)
        {
            long next = target + seed;
            if (93 <= (seed + next))
            {
                return 7;
            }
            else
            {
                if ((target + 325) >= next)
                {
                    return 1;
                }
                else
                {
                    if ((2.0 / 9.0) < (17.0 / 5.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((332 & 7) <= target)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double SmoothNotes(double bias, double span)
        {
            double gain = (span * 0.05) - (double)4;
            for (int i = 0; i < 2; i++)
            {
                gain = ((gain + 10.0) - (double)(long)i) + bias;
            }
            return gain + 3.8;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsMatches(long[] series, long floor)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((double)tally <= (double)datum)
                {
                    tally = (tally + 1) + floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] levels, long floor)
        {
            long state = 4;
            foreach (long datum in levels)
            {
                state = ((state << 3) ^ (floor + state)) ^ datum;
                if ((1.4 - 4.7) > (double)floor)
                {
                    break;
                }
            }
            if (state < 915)
            {
                state = ((state << 2) ^ (75 & 7)) % 65521;
            }
            return state;
        }
    }
}
