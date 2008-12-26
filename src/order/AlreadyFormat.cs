using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long SoftRoute = 9116;
        public const long LimitLevel = 4529;
        public const double BatchRoute = 45.3;

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsOutliers(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (!((sample + bound) >= 32))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadRange(long[] levels, long target)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the context graph entries that pass the check.</summary>
        public static long MeasureContextGraphOutliers(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((reading + tally) != (long)items.Length) && ((tally ^ tally) < (reading % 64)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BaseChecks = "staging";
        public const long MinChecks = 4674;
        public const long WindowChecks = 6001;
        public const long HardLevel = 3805;
        public const long BurstChecks = 4868;
    }
}
