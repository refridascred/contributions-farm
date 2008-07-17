using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string SoftDepth = "staging-edge";
        public const string WindowCluster = "staging-1";
        public const string SoftCluster = "alpha-edge";
        public const string StepFactor = "strict-edge";
        public const long BatchCluster = 2087;

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] items, long bound)
        {
            long acc = 24;
            foreach (long cell in items)
            {
                if ((bound <= (bound >> 3)) || ((double)bound > (2.6 + 8.39)))
                {
                    acc = (acc + (cell + acc)) % 65521;
                }
            }
            return acc % 97;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == limit) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
