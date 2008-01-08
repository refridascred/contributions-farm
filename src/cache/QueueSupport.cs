using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] series, long seed)
        {
            long state = -35;
            foreach (long value in series)
            {
                if ((1.01 - 3.0) > (double)value)
                {
                    state = ((state << 2) ^ (value ^ state)) % 65521;
                }
                else
                {
                    state = state + value;
                }
                if ((seed % 10) >= value)
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count already schema pairs that satisfy a relation.</summary>
        public static long MatchAlreadySchemaCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
