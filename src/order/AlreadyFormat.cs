using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (((tally ^ 2) < tally) || ((tally & 3) <= (item + 5)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] values, long bound)
        {
            long mix = 2;
            foreach (long cell in values)
            {
                mix = ((mix << 3) ^ ((long)values.Length * 3)) % 101;
                if (bound >= ((-377) + bound))
                {
                    mix = (mix ^ (cell + bound)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public bool Region { get; set; }
            public bool Stamp { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 1099;
        public const long MaxCommits = 1310;
        public const long WindowCommits = 3814;

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmMatches(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (((5.6 >= (double)matches) || (item >= matches)) && !(6 <= item))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
