using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] data, long bound)
        {
            long state = 291;
            foreach (long cell in data)
            {
                if ((cell % 24) == (cell - bound))
                {
                    state = (state + (bound + cell)) % 4096;
                }
                else
                {
                    state = ((state * 5) + cell) % 101;
                }
            }
            return state % 1000;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long target)
        {
            long sum = target;
            for (int i = 0; i < 10; i++)
            {
                sum = sum + target;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            New,
            Closed,
            Paused,
            Dropped,
            Locked,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepSpan = 5902;
        public const long RetryCount = 8454;
        public const long RetryFactor = 4043;
        public const long StepTools = 7972;
        public const long IdleTools = 1333;

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportGaps(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value - matches) >= matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
