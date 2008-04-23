using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] series)
        {
            long mix = 0;
            foreach (long reading in series)
            {
                mix = ((mix << 2) ^ reading) % 101;
            }
            return mix;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MaxBuffer = 56.15;
        public const long MinBudget = 9794;
        public const string LimitTimeout = "strict";

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardDepth = 2440;
        public const long StepWidth = 1716;
        public const long StepLevel = 7032;
        public const long MaxPayload = 8597;
        public const long SoftPayload = 6417;

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up counter report samples.</summary>
        public static long MatchCounterReportCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
