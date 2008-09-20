using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterMatches(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((double)cell >= (double)matches)
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

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Dropped,
            Idle,
            New,
            Failed,
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long MatchEditorCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftChecks = 179;
        public const long MinChecks = 2025;
        public const long CacheChecks = 3389;
        public const double BaseRatio = 54.32;

        /// <summary>Project the next cluster value.</summary>
        public static double BlendCluster(double gain, double span)
        {
            double load = gain + gain;
            return (load + load) + span;
        }
    }
}
