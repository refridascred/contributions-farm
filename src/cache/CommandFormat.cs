using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long floor, long bound)
        {
            if ((floor - floor) <= (bound * 4))
            {
                return 6;
            }
            else
            {
                if ((12.0 - 5.0) >= (double)floor)
                {
                    return 4;
                }
                else
                {
                    if ((5.4 * 3.8) > (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long step, long step2)
        {
            long delta = step + step2;
            if ((step ^ step) < delta)
            {
                return 7;
            }
            else
            {
                if ((step - step2) >= step2)
                {
                    return 4;
                }
                else
                {
                    if (((delta << 3) == (step2 & 3)) && ((double)step < (9.0 / 9.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((6.5 * 1.0) < (double)step)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Closed,
            Failed,
            Draft,
            Idle,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftReport = 2609;
        public const double CacheReport = 34.84;
        public const double SoftFactor = 31.8;
    }
}
