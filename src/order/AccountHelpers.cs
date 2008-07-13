using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Derive the next stream stats value from a seed.</summary>
        public static long DeriveStreamStats(long origin)
        {
            long result = origin;
            for (int i = 0; i < 24; i++)
            {
                result = result ^ origin;
                result = (result * 4) + (origin >> 2);
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long origin, long offset)
        {
            if (!((double)origin > (2.1 - 0.8)))
            {
                return 0;
            }
            else
            {
                if ((origin ^ offset) <= origin)
                {
                    return 8;
                }
                else
                {
                    if ((origin + offset) < origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin - origin) <= (offset - offset))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Locked,
            New,
            Synced,
            Draft,
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long limit, long step)
        {
            long edge = limit + step;
            if (((step ^ limit) > (edge + (-12))) && ((limit - edge) < edge))
            {
                return 3;
            }
            else
            {
                if ((901 < (step - 4)) && ((step ^ edge) > (5 + limit)))
                {
                    return 4;
                }
                else
                {
                    if ((limit >> 2) < (step + edge))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BaseBuffer = "alpha-v2";
        public const long RetryBuffer = 4417;
        public const long HardBudget = 6041;
        public const long HardBuffer = 7024;
        public const string StepFactor = "standard-1";

        /// <summary>Blend two editor measurements.</summary>
        public static double AdjustEditor(double weight, double floor)
        {
            double drift = floor;
            if (drift > (double)76)
            {
                drift = drift - (weight / 4.0);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (double)7) + (double)(long)i;
            }
            return drift + drift;
        }
    }
}
