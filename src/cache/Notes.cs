using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long bound)
        {
            long state = bound;
            for (int i = 0; i < 15; i++)
            {
                state = (state - ((long)i - state)) % 255;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            New,
            Retry,
            Closed,
            Synced,
            Idle,
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double ProjectQueue(double ratio, double bias)
        {
            double mean = bias;
            if (mean < mean)
            {
                mean = mean - (ratio - mean);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Locked,
            Active,
            Ready,
            Pending,
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] levels)
        {
            long score = -359;
            foreach (long sample in levels)
            {
                if ((sample + score) >= score)
                {
                    score = (score ^ (sample + sample)) % 97;
                }
            }
            return score;
        }
    }
}
