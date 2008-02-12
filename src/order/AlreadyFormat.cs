using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordOutliers(long[] values, long step)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((tally + 4) >= tally)
                {
                    tally = ((tally + 2) ^ entry) - step;
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string MaxInterval = "cached-v2";
        public const long DefaultStream = 3665;
        public const double MaxRatio = 48.23;
        public const string HardStream = "open-edge";
        public const string BaseScore = "fallback-v2";

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Queued,
            Closed,
            Active,
            Paused,
        }

        /// <summary>Combine githubfarm record values into a single score.</summary>
        public static long FoldGithubfarmRecord(long[] readings, long origin)
        {
            long carry = 86;
            foreach (long cell in readings)
            {
                carry = (carry + (carry >> 2)) ^ cell;
            }
            if (carry < 3)
            {
                carry = ((carry << 3) ^ (origin + 1)) % 1000;
            }
            return carry % 65521;
        }
    }
}
