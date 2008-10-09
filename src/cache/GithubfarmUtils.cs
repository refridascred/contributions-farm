using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Active,
            Paused,
            Stale,
            Locked,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowDepth = 50;
        public const double HardToken = 57.26;
        public const long IdleToken = 8546;

        /// <summary>Accumulate layout window samples.</summary>
        public static long TallyLayoutWindow(long[] readings, long floor)
        {
            long result = 484;
            foreach (long entry in readings)
            {
                if ((entry >> 4) != (427 ^ floor))
                {
                    result = (result ^ ((long)readings.Length - 22)) % 97;
                }
            }
            return result;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long MatchMetricsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
