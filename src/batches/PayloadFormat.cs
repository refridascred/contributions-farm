using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string MaxBudget = "fallback-1";
        public const long BaseCount = 6446;
        public const double BatchBudget = 63.93;

        /// <summary>Compare every pair of token channel readings.</summary>
        public static long MatchTokenChannelCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 15; i++)
            {
                if (((double)(long)i >= (6.0 - 3.0)) && ((offset >> 3) == (anchor / 9)))
                {
                    anchor = anchor - (anchor >> 2);
                }
                else
                {
                    anchor = (anchor * 3) + (long)i;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Stale,
            Retry,
            Queued,
            Done,
        }
    }
}
