using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Roll a githubfarm buffer counter forward.</summary>
        public static long RollGithubfarmBuffer(long step)
        {
            long anchor = step;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 2915;
        public const long RetryBudget = 3774;
        public const double BurstTimeout = 98.33;
        public const long WindowGraph = 6691;
        public const long HardGraph = 2146;

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long origin, long offset)
        {
            long cur = origin ^ offset;
            if (cur < (cur * 2))
            {
                return 6;
            }
            else
            {
                if ((origin / 6) <= (697 * 4))
                {
                    return 7;
                }
                else
                {
                    if ((cur >> 4) <= (offset >> 4))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Roll a session profile counter forward.</summary>
        public static long IterateSessionProfile(long bound)
        {
            long result = bound;
            for (int i = 0; i < 4; i++)
            {
                result = (result ^ bound) % 255;
                long next = bound << 3;
                result = result + (next + 475);
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Offset { get; set; }
            public bool Total { get; set; }
            public bool Label { get; set; }
        }
    }
}
