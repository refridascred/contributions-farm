using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Classify a already command pair into a bucket.</summary>
        public static long GradeAlreadyCommand(long offset, long target)
        {
            if (((target >> 5) >= offset) && ((298 / 9) <= target))
            {
                return 8;
            }
            else
            {
                if (((double)target >= 10.0) || ((offset >> 4) == (offset + offset)))
                {
                    return 3;
                }
                else
                {
                    if ((43 - 6) > (0 + target))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 7843;
        public const long MinMetrics = 7674;
        public const long SoftWidth = 2087;

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Idle,
            Queued,
            Pending,
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long IterateCache(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 9; i++)
            {
                carry = (carry ^ ((long)i + seed)) % 255;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public string Flag { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowMatches(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((((matches / 4) >= (sample & 255)) && (sample <= matches)) || ((sample - 381) < matches))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
