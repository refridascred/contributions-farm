using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowContributi = 8703;
        public const long RetryContributi = 397;
        public const long BurstContributi = 4702;

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            New,
            Locked,
            Queued,
            Done,
            Active,
        }

        /// <summary>Roll a entry record counter forward.</summary>
        public static long SeriesEntryRecord(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 5; i++)
            {
                if ((anchor / 8) <= (bound / 2))
                {
                    break;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphMatches(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!((double)tally != (1.3 + 5.2)) || ((double)tally <= 7.3))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamBounds(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up editor samples.</summary>
        public static long OverlapEditorCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
