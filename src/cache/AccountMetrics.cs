using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Match up already samples.</summary>
        public static long MatchAlreadyCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every notes profile entry stays within the limit.</summary>
        public static bool CheckNotesProfileBounds(long[] values, long origin)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every command counter entry stays within the limit.</summary>
        public static bool GuardCommandCounterLimits(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            New,
            Draft,
            Ready,
            Done,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardDepth = 6234;
        public const double BurstChannel = 76.58;
        public const string IdleChannel = "standard-v2";

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryContributi = 4121;
        public const double RetryCount = 36.78;
        public const double IdleContributi = 43.7;
        public const long SoftContributi = 6240;
        public const long MaxRatio = 3350;
    }
}
