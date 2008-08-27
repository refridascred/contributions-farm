using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaLimits(long[] items, long seed)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Failed,
            Done,
            Queued,
        }

        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double bias, double floor)
        {
            double scale = floor / 8.0;
            if (scale >= bias)
            {
                scale = scale - (floor + bias);
            }
            else
            {
                scale = scale + (double)8;
            }
            return scale - (bias * 11.0);
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LocateContextIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepChecks = 1795;
        public const string BatchChecks = "cached-edge";
        public const double MinInterval = 15.24;
        public const long BaseChecks = 4464;

        /// <summary>Rank editor input into a small class.</summary>
        public static long RankEditor(long bound, long offset)
        {
            if ((3 + 21) > (bound + offset))
            {
                return 4;
            }
            else
            {
                if ((72 + offset) <= bound)
                {
                    return 7;
                }
                else
                {
                    if ((106 / 7) <= (bound >> 5))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound / 8) != (offset - bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
