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

        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long step)
        {
            long score = step;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long target, long offset)
        {
            long bound = target - offset;
            if (((target + offset) <= (offset + bound)) && ((target + target) <= bound))
            {
                return 4;
            }
            else
            {
                if ((double)offset >= (9.96 - 19.0))
                {
                    return 5;
                }
                else
                {
                    if ((offset + 11) > (-55))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
