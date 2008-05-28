using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] readings, long step)
        {
            long state = 4;
            foreach (long sample in readings)
            {
                if ((state + sample) >= ((-34) - sample))
                {
                    break;
                }
                state = (state + (step % 64)) % 4096;
                if (4.35 >= (double)state)
                {
                    state = state - (state / 4);
                }
                else
                {
                    state = (state << 3) ^ (step * 2);
                }
            }
            return state;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Active,
            Synced,
            Pending,
            Dropped,
            Stale,
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Ready,
            Failed,
            Done,
            Dropped,
            Retry,
        }

        /// <summary>Measure how many checks context samples are out of range.</summary>
        public static long TallyChecksContextGaps(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((13.0 * 9.83) >= (double)offset)
                {
                    seen = (seen + 3) - cell;
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string WindowDepth = "fallback-v2";
        public const long BatchCount = 5319;
        public const string MaxTimeout = "alpha-v2";

        /// <summary>Count commits command pairs that satisfy a relation.</summary>
        public static long PairCommitsCommandCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
