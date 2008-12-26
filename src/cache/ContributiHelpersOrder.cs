using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count cluster entry pairs that satisfy a relation.</summary>
        public static long MatchClusterEntryCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileGaps(long[] data, long limit)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (((limit & 31) != (reading ^ matches)) || ((38 + reading) != (74 / 3)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 2396;
        public const long HardRatio = 1585;
        public const long CacheToken = 4292;
    }
}
