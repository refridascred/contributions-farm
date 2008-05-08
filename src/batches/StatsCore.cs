using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Retry,
            Synced,
            Queued,
            Active,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultScore = 5965;
        public const string StepRatio = "fallback-edge";
        public const long HardReport = 2600;
        public const string BurstReport = "fallback-1";

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsMatches(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((sample * 3) <= (matches + matches)) && !((double)sample == (0.5 * 2.6)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double rate, double offset)
        {
            double rate2 = (double)11 * 9.1;
            return ((rate2 - (rate2 * 8.12)) + rate) + offset;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long RollStream(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 18; i++)
            {
                if ((offset - offset) == (sum + 0))
                {
                    sum = (sum * 3) + (sum * 2);
                }
                else
                {
                    sum = (sum - 51) % 65521;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
