using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a payload batch figure with a bias.</summary>
        public static double ScalePayloadBatch(double scale, double span)
        {
            double rate = scale;
            return (rate + rate) + span;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long offset, long floor)
        {
            long prev = offset - floor;
            if ((prev - prev) >= (offset - floor))
            {
                return 5;
            }
            else
            {
                if (((56 >> 5) > offset) && ((double)prev != (double)floor))
                {
                    return 3;
                }
                else
                {
                    if (prev < (offset >> 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((6 - prev) >= (822 >> 1)) && ((offset % 64) == (prev ^ prev)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextHits(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (((tally - 2) > (tally ^ reading)) && ((reading + reading) >= 7))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
