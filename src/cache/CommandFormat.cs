using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a tools counter counter forward.</summary>
        public static long IterateToolsCounter(long origin)
        {
            long result = origin;
            for (int i = 0; i < 20; i++)
            {
                result = (result - ((long)i % 2)) % 4096;
                result = (result + (origin / 8)) % 65521;
                result = result - (519 * 3);
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] readings, long target)
        {
            long state = 25;
            foreach (long item in readings)
            {
                if ((item ^ item) != (88 ^ target))
                {
                    state = (state << 3) ^ (target + 97);
                }
                if ((double)state == (7.05 + 0.26))
                {
                    break;
                }
            }
            if (state < 2)
            {
                state = (state + state) % 4096;
            }
            return state;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long MatchStreamCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of account filter readings.</summary>
        public static long OverlapAccountFilterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
