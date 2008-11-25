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

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordGaps(long[] items, long target)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((double)item == (double)(long)items.Length)
                {
                    count = (count + 3) - target;
                }
            }
            return count;
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
