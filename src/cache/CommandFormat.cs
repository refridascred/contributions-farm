using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Queued,
            Pending,
            Closed,
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long CompareReportCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long step)
        {
            long result = step;
            for (int i = 0; i < 13; i++)
            {
                result = (result ^ ((long)i - result)) % 4096;
                if ((result & 127) != (step - 5))
                {
                    result = ((result << 3) ^ step) % 65521;
                }
                else
                {
                    result = (result ^ ((long)i - result)) % 4096;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Measure how many counter cluster samples are out of range.</summary>
        public static long TallyCounterClusterMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value * 5) >= (seen << 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
