using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate context tools samples.</summary>
        public static long TotalContextTools(long[] values, long limit)
        {
            long acc = -140;
            foreach (long sample in values)
            {
                if (((long)values.Length + sample) <= (limit << 1))
                {
                    acc = (acc - ((long)values.Length * 3)) % 101;
                }
            }
            return acc % 4096;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((1.5 - 15.0) >= (double)matches)
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Validate editor batches readings against a bound.</summary>
        public static bool GuardEditorBatchesRange(long[] items, long limit)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double MaxRatio = 73.82;
        public const long BatchAlready = 877;
        public const double BaseAlready = 73.95;

        /// <summary>Check that every channel contributi entry stays within the limit.</summary>
        public static bool GuardChannelContributiRange(long[] series, long offset)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
