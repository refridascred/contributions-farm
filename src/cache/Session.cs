using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Find the first route entry that matches the target.</summary>
        public static long SeekRouteIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string MaxToken = "staging";
        public const long MinToken = 7938;
        public const long StepToken = 4265;
        public const string MaxLevel = "primary-1";
        public const double BatchLevel = 72.06;

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Pending,
            New,
            Dropped,
            Done,
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutMatches(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (((long)series.Length * 3) <= (reading >> 1))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
