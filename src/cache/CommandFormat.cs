using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long origin, long bound)
        {
            if ((bound & 31) <= 77)
            {
                return 4;
            }
            else
            {
                if (bound <= (bound + origin))
                {
                    return 8;
                }
                else
                {
                    if ((((-587) ^ origin) > (origin - origin)) && ((origin + 117) >= (3 * 3)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MinContext = "legacy-1";
        public const string IdleWidth = "fallback-1";
        public const long MaxContext = 4255;
        public const long LimitInterval = 7124;
        public const long IdleContext = 9056;

        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiMatches(long[] readings, long origin)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (origin > (origin + sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
