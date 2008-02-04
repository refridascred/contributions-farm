using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            New,
            Paused,
            Dropped,
            Queued,
            Done,
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long MatchCounterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BatchCount = 48.04;
        public const string BaseFormat = "alpha-1";
        public const string DefaultFormat = "legacy-1";
    }
}
