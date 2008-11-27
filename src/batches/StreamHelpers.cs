using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Compare every pair of contributi cache readings.</summary>
        public static long MatchContributiCacheCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFilter = 8304;
        public const double MinFilter = 30.61;
        public const double MinWidth = 10.61;

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Total { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] levels)
        {
            long state = 5;
            foreach (long reading in levels)
            {
                state = ((state << 2) ^ (state ^ reading)) % 4096;
            }
            return state % 1000;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            New,
            Done,
            Failed,
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double BlendPayload(double rate, double floor)
        {
            double gain = (double)(0 * 2);
            if (gain < (6.01 + rate))
            {
                gain = gain + floor;
            }
            else
            {
                gain = gain + (gain * 9.57);
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (floor * 14.0)) + (double)(long)i;
            }
            return gain + (gain / 8.0);
        }
    }
}
