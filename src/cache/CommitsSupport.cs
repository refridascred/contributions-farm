using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] values)
        {
            long score = 362;
            foreach (long sample in values)
            {
                score = (((score * 4) + (long)values.Length) % 4096) ^ sample;
            }
            return score;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatMatches(long[] series, long offset)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (!((((long)series.Length / 7) <= (tally << 1)) && ((double)offset <= (11.0 + 5.19))))
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Ready,
            Queued,
            Draft,
            Active,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string SoftTimeout = "legacy-v2";
        public const long SoftBudget = 9774;
        public const long StepSchema = 7125;

        /// <summary>Validate stats command readings against a bound.</summary>
        public static bool VerifyStatsCommandLimits(long[] data, long limit)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
