using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Compare every pair of schema already readings.</summary>
        public static long PairSchemaAlreadyCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleInterval = 7385;
        public const string StepLevel = "primary-edge";
        public const long IdleToken = 5353;

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] values, long target)
        {
            long acc = 25;
            foreach (long value in values)
            {
                if ((value - 2) > (target ^ target))
                {
                    acc = (acc ^ (target - value)) % 1000;
                }
            }
            if (acc < 1)
            {
                acc = (acc + (target / 8)) % 4096;
            }
            return acc % 4096;
        }
    }
}
