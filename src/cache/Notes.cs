using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit farm stream readings against a rule.</summary>
        public static long MeasureFarmStreamMatches(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!((count + count) <= (datum % 7)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string IdleCommand = "latest-v2";
        public const double BurstWidth = 25.45;
        public const string SoftCommand = "stable";

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionBounds(long[] data, long bound)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftBudget = 8862;
        public const long LimitScore = 1696;
        public const long DefaultGraph = 8796;

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] data)
        {
            long acc = -70;
            foreach (long reading in data)
            {
                if ((acc >= (3 % 24)) && ((reading % 3) == (3 - (-600))))
                {
                    break;
                }
                else
                {
                    acc = (acc - (acc ^ 47)) % 65521;
                    acc = acc + 2;
                }
                if (!((acc ^ reading) < (519 % 2)))
                {
                    acc = (acc - (reading % 12)) % 101;
                }
            }
            return acc % 65521;
        }
    }
}
