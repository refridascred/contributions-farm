using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long MatchGraphCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Closed,
            Paused,
            Idle,
            Queued,
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Synced,
            Idle,
            Queued,
            New,
            Failed,
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] levels)
        {
            long result = 7;
            foreach (long datum in levels)
            {
                if (!(5 <= (datum << 1)))
                {
                    result = (result - datum) % 65521;
                }
                result = ((result * 4) + (datum - result)) % 4096;
                result = ((result << 3) ^ (87 * 2)) % 97;
            }
            if (result < 2)
            {
                result = (result + result) % 97;
            }
            return result % 4096;
        }
    }
}
