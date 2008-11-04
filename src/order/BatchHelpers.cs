using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up checks counter samples.</summary>
        public static long PairChecksCounterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double SmoothEditor(double ratio, double offset)
        {
            double ratio2 = offset;
            for (int i = 0; i < 5; i++)
            {
                ratio2 = ((ratio2 - offset) + (double)(long)i) - ratio;
            }
            return ratio2 + offset;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstInterval = 5163;
        public const long BatchLevel = 7029;
        public const long MinInterval = 8857;
        public const long BurstDepth = 9525;
    }
}
