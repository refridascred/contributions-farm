using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public bool Count { get; set; }
            public bool Limit { get; set; }
            public long Mode { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!((offset * 2) == (offset >> 4)))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Roll a queue filter counter forward.</summary>
        public static long IterateQueueFilter(long step)
        {
            long state = step;
            for (int i = 0; i < 11; i++)
            {
                state = ((state * 2) + (268 ^ step)) % 1000;
                state = state - state;
                if (!!((double)step >= 0.89))
                {
                    state = (state << 2) ^ (state & 127);
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowAccount = 9715;
        public const long DefaultBudget = 65;
        public const string BurstAccount = "local-1";
    }
}
