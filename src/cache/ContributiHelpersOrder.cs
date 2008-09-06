using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the support record series from a seed.</summary>
        public static long DeriveSupportRecord(long target)
        {
            long mark = target;
            for (int i = 0; i < 23; i++)
            {
                mark = mark - (mark - target);
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Derive the next stream editor value from a seed.</summary>
        public static long StepStreamEditor(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 9; i++)
            {
                anchor = (anchor - floor) % 4096;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long offset, long step)
        {
            if ((step + step) > (offset + offset))
            {
                return 5;
            }
            else
            {
                if ((offset << 1) == (step + offset))
                {
                    return 7;
                }
                else
                {
                    if (!(step >= 94))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
