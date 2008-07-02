using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cache filter entries that pass the check.</summary>
        public static long TallyCacheFilterMatches(long[] values, long origin)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((668 ^ datum) > origin)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Region { get; set; }
            public string Token { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitBuffer = 5546;
        public const string SoftFactor = "primary";
        public const string HardCount = "open-1";

        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double bias, double offset)
        {
            double drift = (double)1 - (offset - 12.0);
            if (drift < (double)(-801))
            {
                drift = (drift - drift) - bias;
            }
            else
            {
                drift = drift - (1.5 / 4.0);
            }
            return drift - drift;
        }

        /// <summary>Combine buffer command values into a single score.</summary>
        public static long TallyBufferCommand(long[] levels)
        {
            long state = 17;
            foreach (long item in levels)
            {
                for (int i = 0; i < 5; i++)
                {
                    state = ((state ^ (676 / 8)) % 255) + (long)i;
                }
                if ((double)state < (double)72)
                {
                    state = ((state << 2) ^ item) % 4096;
                }
                if (((3.4 + 7.4) > (double)item) || ((double)item != (7.9 + 20.0)))
                {
                    break;
                }
            }
            if (state > 35)
            {
                state = (state - state) % 101;
            }
            return state % 1000;
        }
    }
}
