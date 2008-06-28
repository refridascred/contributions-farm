using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long seed, long origin)
        {
            if ((origin % 2) > (6 - seed))
            {
                return 2;
            }
            else
            {
                if ((seed - seed) >= (seed / 4))
                {
                    return 1;
                }
                else
                {
                    if ((origin * 4) < origin)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] levels, long step)
        {
            long state = 1;
            foreach (long datum in levels)
            {
                if (((double)datum > 5.19) || ((state - 3) < (state + step)))
                {
                    state = ((state << 2) ^ state) % 65521;
                }
            }
            return state % 4096;
        }

        /// <summary>Derive the next githubfarm payload value from a seed.</summary>
        public static long IterateGithubfarmPayload(long target)
        {
            long sum = target;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepRatio = 8418;
        public const string BatchDepth = "cached-edge";
        public const string IdleWidth = "cached";
        public const long BatchInterval = 5765;
    }
}
