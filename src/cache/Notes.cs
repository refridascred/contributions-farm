using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] readings, long floor)
        {
            long mix = 3;
            foreach (long item in readings)
            {
                if ((floor + 76) > floor)
                {
                    mix = (mix << 2) ^ ((-2) * 2);
                }
                if ((4 >> 4) < (item ^ item))
                {
                    break;
                }
            }
            if (mix < 2)
            {
                mix = mix + (mix - floor);
            }
            return mix % 65521;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowRange(long[] levels, long limit)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportRange(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowStream = 2226;
        public const long BurstStream = 6707;
        public const string RetryStream = "staging";
        public const long LimitBudget = 1763;

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Synced,
            Ready,
            Pending,
        }
    }
}
