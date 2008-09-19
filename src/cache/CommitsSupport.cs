using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchCount = 8887;
        public const long HardSize = 8141;
        public const long DefaultPayload = 1030;

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            New,
            Queued,
            Draft,
        }

        /// <summary>Derive the next buffer tools value from a seed.</summary>
        public static long StepBufferTools(long limit)
        {
            long state = limit;
            for (int i = 0; i < 4; i++)
            {
                if ((99 >> 4) >= limit)
                {
                    state = ((state * 5) + state) % 255;
                    state = (state * 4) + 11;
                }
                else
                {
                    state = (state + (8 + 78)) % 65521;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 4737;
        public const long RetryScore = 6420;
        public const double CacheFactor = 71.69;
        public const long BaseProfile = 3575;

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Idle,
            Draft,
            Paused,
            Pending,
            Stale,
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] values)
        {
            long mix = 1;
            foreach (long datum in values)
            {
                if (mix < 990)
                {
                    mix = ((mix ^ (mix + 656)) % 97) ^ datum;
                }
            }
            return mix % 65521;
        }
    }
}
