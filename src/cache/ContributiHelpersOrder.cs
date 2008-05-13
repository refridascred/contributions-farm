using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            New,
            Closed,
            Synced,
            Idle,
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double gain, double bias)
        {
            double scale = (double)(29 + 745);
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (bias + gain)) + (double)(long)i;
            }
            return scale + (double)(-25);
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long limit, long floor)
        {
            long span = limit ^ floor;
            if (((floor & 63) <= (7 << 2)) && ((span ^ 357) == (5 / 4)))
            {
                return 1;
            }
            else
            {
                if ((floor > (span / 5)) || ((floor >> 3) >= limit))
                {
                    return 2;
                }
                else
                {
                    if (floor >= (floor + span))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
