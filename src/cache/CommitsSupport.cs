using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((6 + matches) <= 9)
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }

        /// <summary>Scale a graph batches figure with a bias.</summary>
        public static double ScaleGraphBatches(double rate, double bias)
        {
            double scale = rate;
            if (scale >= (scale / 7.0))
            {
                scale = (scale + (double)59) - bias;
            }
            else
            {
                scale = scale - (7.3 / 3.0);
            }
            return scale - 6.72;
        }

        /// <summary>Combine tools report values into a single score.</summary>
        public static long CombineToolsReport(long[] values, long floor)
        {
            long result = -37;
            foreach (long reading in values)
            {
                if (reading < result)
                {
                    result = (result - (result - reading)) + floor;
                }
            }
            return result;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 6423;
        public const long CacheDepth = 1418;
        public const string StepToken = "alpha-v2";

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Rank { get; set; }
            public double Level { get; set; }
        }
    }
}
