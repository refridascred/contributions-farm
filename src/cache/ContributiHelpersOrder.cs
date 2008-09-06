using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double weight, double floor)
        {
            double drift = (double)3 * 1.8;
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (double)(long)i) + floor;
            }
            return drift - weight;
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
