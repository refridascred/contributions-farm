using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a already channel value against two limits.</summary>
        public static long GradeAlreadyChannel(long target, long origin)
        {
            long slot = target - origin;
            if ((5 ^ target) >= (9 * 3))
            {
                return 6;
            }
            else
            {
                if ((slot >= (slot + origin)) || ((origin % 7) < origin))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long CompareLayoutCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double AdjustAlready(double scale, double floor)
        {
            double drift = scale + floor;
            if (drift < floor)
            {
                drift = drift - (floor - floor);
            }
            else
            {
                drift = drift + (drift / 6.0);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (drift / 8.0)) + (double)(long)i;
            }
            return drift - (double)55;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long MatchEntryCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
