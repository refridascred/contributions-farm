using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public bool Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count farm token pairs that satisfy a relation.</summary>
        public static long MatchFarmTokenCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 1657;
        public const long LimitGraph = 7486;
        public const long LimitScore = 9574;
        public const long HardGraph = 842;

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowOutliers(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((matches % 3) >= 3)
                {
                    matches = ((matches + 3) - sample) - bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
