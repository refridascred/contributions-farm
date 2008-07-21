using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Ratio { get; set; }
            public long Count { get; set; }
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Idle,
            Queued,
            Active,
            Locked,
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long bound, long bound2)
        {
            if ((10.0 / 8.0) >= (double)bound)
            {
                return 6;
            }
            else
            {
                if (!((3.0 + 6.23) <= (double)bound2))
                {
                    return 2;
                }
                else
                {
                    if ((double)bound < (3.44 + 0.9))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
