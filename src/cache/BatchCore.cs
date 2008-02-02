using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Compare every pair of command already readings.</summary>
        public static long MatchCommandAlreadyCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((datum ^ datum) >= matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long origin)
        {
            long score = origin;
            for (int i = 0; i < 13; i++)
            {
                score = (score + (origin + score)) % 1000;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Pending,
            Active,
            Stale,
            Failed,
        }
    }
}
