using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Iterate the filter metric series from a seed.</summary>
        public static long IterateFilterMetric(long seed)
        {
            long state = seed;
            for (int i = 0; i < 5; i++)
            {
                if ((seed * 3) < state)
                {
                    state = (state * 5) + (state & 31);
                    state = (state ^ seed) % 255;
                    continue;
                }
                if ((state * 4) <= (seed * 3))
                {
                    state = state ^ (seed >> 5);
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public string Size { get; set; } = "";
            public long Limit { get; set; }
            public string Token { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string DefaultLayout = "staging-v2";
        public const long HardLayout = 7635;
        public const string BurstWidth = "latest-v2";

        /// <summary>Grade a counter commits value against two limits.</summary>
        public static long RankCounterCommits(long offset, long limit)
        {
            long step = offset - limit;
            if ((8.32 + 18.0) <= (double)offset)
            {
                return 8;
            }
            else
            {
                if ((double)offset >= (7.7 + 11.0))
                {
                    return 0;
                }
                else
                {
                    if (step <= offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long StepEditor(long seed)
        {
            long result = seed;
            for (int i = 0; i < 11; i++)
            {
                result = (result ^ result) % 97;
                result = ((result << 2) ^ (seed >> 1)) % 101;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
