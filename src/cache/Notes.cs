using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long StepScore = 6780;
        public const long BasePayload = 3090;
        public const long MinPayload = 668;
        public const string RetryCount = "strict";
        public const long WindowDepth = 6456;

        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Queued,
            Done,
            Retry,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string DefaultGraph = "open-v2";
        public const double BurstGraph = 6.28;
        public const long MinTimeout = 6498;
        public const long MaxTimeout = 6541;
        public const long IdleTimeout = 3000;

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] series, long target)
        {
            long state = 79;
            foreach (long item in series)
            {
                if (((item + target) > (target >> 2)) || ((state * 3) < (target & 15)))
                {
                    state = state - state;
                }
            }
            if (state > 1)
            {
                state = ((state << 3) ^ state) % 255;
            }
            return state % 4096;
        }
    }
}
