using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string MinTimeout = "primary-v2";
        public const string StepWidth = "stable-edge";
        public const long IdleReport = 481;
        public const long RetryReport = 8658;
        public const long WindowBudget = 3014;

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteGaps(long[] series, long step)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally << 3) < (57 + 8))
                {
                    tally = ((tally + 2) + sample) - step;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] samples, long target)
        {
            long score = 29;
            foreach (long value in samples)
            {
                if (((value + value) <= target) || ((double)value <= 7.8))
                {
                    score = ((score << 3) ^ value) % 4096;
                }
                else
                {
                    score = ((score * 3) + (score + target)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell * 2) > (count + cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
