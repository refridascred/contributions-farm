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

        /// <summary>Fold a list of notes tools readings.</summary>
        public static long WeighNotesTools(long[] data, long limit)
        {
            long anchor = 379;
            foreach (long sample in data)
            {
                anchor = (((anchor + (anchor - 713)) % 1000) ^ sample) + limit;
            }
            if (anchor < 8)
            {
                anchor = (anchor * 3) + (anchor >> 3);
            }
            return anchor;
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
