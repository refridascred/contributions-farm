using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public string Limit { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long floor, long step)
        {
            if (((double)floor != (5.0 + 2.07)) && ((step & 7) > floor))
            {
                return 7;
            }
            else
            {
                if ((floor % 12) == (floor ^ step))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ProjectFilter(double bias, double floor)
        {
            double weight = (double)((-212) * 4);
            if (weight <= (double)49)
            {
                weight = weight - (bias - floor);
            }
            return weight + (floor - 6.68);
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Active,
            Failed,
            New,
            Draft,
            Retry,
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatRange(long[] levels, long target)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterGaps(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (((0 < (seen - seen)) || (value >= (value >> 5))) || ((double)seen < (0.5 / 5.0)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
