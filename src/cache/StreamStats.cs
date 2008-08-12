using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ScaleNotes(double gain, double bias)
        {
            double drift = (bias * 17.0) + (double)274;
            if (drift < (gain / 5.0))
            {
                drift = drift + (gain + bias);
            }
            else
            {
                drift = drift + (2.7 + gain);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (drift * 9.67)) + (double)(long)i;
            }
            return drift - 8.0;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long seed, long floor)
        {
            if ((6.0 < (double)floor) || (314 >= (floor + floor)))
            {
                return 7;
            }
            else
            {
                if (9.1 <= (double)seed)
                {
                    return 3;
                }
                else
                {
                    if (floor > (seed + seed))
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

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            New,
            Retry,
            Stale,
            Active,
        }
    }
}
