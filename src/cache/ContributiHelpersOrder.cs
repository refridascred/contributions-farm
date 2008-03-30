using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long step, long limit)
        {
            long next = step ^ limit;
            if ((next - (-617)) != (limit << 1))
            {
                return 7;
            }
            else
            {
                if (limit < (next % 16))
                {
                    return 0;
                }
                else
                {
                    if ((next + step) != (step + step))
                    {
                        return 5;
                    }
                    else
                    {
                        if (limit >= (step >> 5))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long bound)
        {
            long total = bound;
            for (int i = 0; i < 14; i++)
            {
                total = (total << 3) ^ (11 & 63);
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long SeriesCommand(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    anchor = ((anchor - floor) % 101) ^ (long)i2;
                }
                long bound = (anchor + floor) - (long)i;
                if ((floor - bound) < (anchor + bound))
                {
                    bound = (bound ^ (8 & 3)) % 97;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
