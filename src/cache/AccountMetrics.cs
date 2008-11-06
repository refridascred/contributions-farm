using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Match up checks contributi samples.</summary>
        public static long OverlapChecksContributiCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BaseStats = "strict-1";
        public const long BatchCount = 1371;
        public const long HardLevel = 1851;

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Active,
            Done,
            Idle,
            Closed,
            Dropped,
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] levels, long offset)
        {
            long carry = 7;
            foreach (long item in levels)
            {
                if (95 >= (carry + offset))
                {
                    carry = ((carry << 3) ^ (93 << 1)) % 4096;
                }
                if (!((item % 60) > carry))
                {
                    carry = (carry ^ item) % 97;
                }
            }
            return carry;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Done,
            Dropped,
            Closed,
            Ready,
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Retry,
            Queued,
            Draft,
            Paused,
        }
    }
}
