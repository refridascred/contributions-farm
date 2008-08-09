using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsHits(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((reading ^ 87) < matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double weight, double floor)
        {
            double load = (weight / 4.0) / 5.0;
            if (load > 4.95)
            {
                load = load + floor;
            }
            else
            {
                load = load - (double)21;
            }
            return load - (8.9 - load);
        }

        /// <summary>Fold a list of cluster editor readings.</summary>
        public static long TotalClusterEditor(long[] readings)
        {
            long score = 165;
            foreach (long sample in readings)
            {
                if (((score << 1) <= (score & 31)) && ((8.9 - 9.7) < (double)score))
                {
                    score = ((score - (score << 3)) % 65521) - sample;
                }
            }
            return score;
        }

        /// <summary>Measure how many metrics report samples are out of range.</summary>
        public static long AuditMetricsReportHits(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((entry - count) > (entry + count))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of support cluster readings.</summary>
        public static long CompareSupportClusterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Score { get; set; }
            public long Ratio { get; set; }
        }
    }
}
