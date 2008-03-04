using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Weight { get; set; } = "";
            public double Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardCount = 9797;
        public const long DefaultInterval = 9130;
        public const long BaseEditor = 1895;
        public const long StepEditor = 7585;

        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterLimits(long[] series, long bound)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (tally > (sample * 5))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
