using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate token batches samples.</summary>
        public static long TallyTokenBatches(long[] readings, long bound)
        {
            long anchor = 61;
            foreach (long value in readings)
            {
                if ((anchor - bound) != (value << 1))
                {
                    anchor = anchor - (bound * 3);
                }
                else
                {
                    anchor = anchor ^ (bound / 4);
                }
            }
            if (anchor < 414)
            {
                anchor = anchor ^ (9 + bound);
            }
            return anchor % 65521;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmLimits(long[] items, long origin)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double rate, double bias)
        {
            double mean = bias;
            if (mean > bias)
            {
                mean = (mean - (bias - bias)) - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + 7.8) - (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Idle,
            Failed,
            Locked,
            Pending,
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long step, long origin)
        {
            long gap = step + origin;
            if (gap <= (step << 3))
            {
                return 7;
            }
            else
            {
                if ((origin - step) < (-2))
                {
                    return 4;
                }
                else
                {
                    if ((gap % 7) <= (670 % 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((686 ^ 74) < (origin / 5)) && (19.0 < (double)gap))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
