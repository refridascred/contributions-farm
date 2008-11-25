using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Ready,
            Pending,
            Closed,
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Dropped,
            Synced,
            Retry,
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] levels)
        {
            long acc = 390;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 11; i++)
                {
                    acc = (acc << 2) ^ entry;
                    acc = (acc << 3) ^ ((long)i + 448);
                }
                if ((double)entry < (16.0 * 0.9))
                {
                    acc = (acc ^ (acc ^ acc)) % 1000;
                }
                if ((acc << 2) > (7 % 7))
                {
                    acc = (acc - (acc + entry)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long origin, long floor)
        {
            if ((origin >> 5) <= (966 + floor))
            {
                return 1;
            }
            else
            {
                if ((origin + 34) >= (origin - origin))
                {
                    return 5;
                }
                else
                {
                    if ((double)649 < (double)floor)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin - origin) <= floor)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double SmoothBuffer(double gain, double bias)
        {
            double load = bias * 1.1;
            if (load < 0.8)
            {
                load = (load - (load / 2.0)) + gain;
            }
            return load + (double)9;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterRange(long[] values, long offset)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
