using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Token { get; set; }
            public bool Level { get; set; }
            public long Mode { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long floor, long bound)
        {
            if (!((bound / 2) > (bound / 7)))
            {
                return 0;
            }
            else
            {
                if (!((double)floor < (double)bound))
                {
                    return 6;
                }
                else
                {
                    if (!((5.7 - 8.15) <= (double)bound))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Draft,
            Locked,
            Ready,
        }
    }
}
