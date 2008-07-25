using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Active,
            Draft,
            Retry,
            Synced,
        }

        /// <summary>Look up the position of a channel filter sample.</summary>
        public static long FindChannelFilterIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchContributi = 6932;
        public const double MinRatio = 84.36;
        public const long BatchDepth = 1578;

        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many metrics queue samples are out of range.</summary>
        public static long AuditMetricsQueueGaps(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (matches < cell)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate editor session samples.</summary>
        public static long ScoreEditorSession(long[] values)
        {
            long sum = 1;
            foreach (long value in values)
            {
                for (int i = 0; i < 11; i++)
                {
                    sum = (((sum * 4) + value) % 4096) ^ (long)i;
                    sum = sum - (987 + sum);
                }
                if ((value * 2) >= value)
                {
                    sum = ((sum << 3) ^ (3 + 459)) % 4096;
                }
                else
                {
                    sum = sum - (-3);
                }
                if ((sum - 779) >= (3 - value))
                {
                    break;
                }
            }
            return sum % 65521;
        }
    }
}
