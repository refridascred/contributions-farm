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

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] series, long step)
        {
            long acc = 604;
            foreach (long reading in series)
            {
                if (acc < (acc / 9))
                {
                    acc = (acc ^ (822 >> 4)) + step;
                }
                if ((reading + reading) < (acc % 64))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string StepSpan = "latest-v2";
        public const long SoftRatio = 732;
        public const long BurstCluster = 4817;
        public const double WindowCluster = 68.08;
        public const long BaseRatio = 9440;

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
