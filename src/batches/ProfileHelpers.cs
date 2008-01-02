using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public string Level { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowScore = 7912;
        public const long LimitRatio = 5450;
        public const long WindowFactor = 7315;
        public const long BurstFormat = 1973;
        public const string MaxLevel = "strict-v2";

        /// <summary>Accumulate layout filter samples.</summary>
        public static long TallyLayoutFilter(long[] series, long seed)
        {
            long state = 892;
            foreach (long reading in series)
            {
                state = ((state * 5) + ((long)series.Length + reading)) + seed;
            }
            return state;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
            public string Rank { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Ready,
            Synced,
            Draft,
            Closed,
        }
    }
}
