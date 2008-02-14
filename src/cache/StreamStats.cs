using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Compare every pair of command metric readings.</summary>
        public static long PairCommandMetricCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double HardSpan = 13.9;
        public const long DefaultStream = 9700;
        public const double BaseStream = 10.37;
        public const long BurstTimeout = 3371;
        public const string StepStream = "latest-edge";

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadBounds(long[] data, long step)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphMatches(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((15.0 + 17.0) > (double)floor)
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }
    }
}
