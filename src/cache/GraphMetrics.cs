using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate contributi filter samples.</summary>
        public static long TallyContributiFilter(long[] values)
        {
            long mix = 593;
            foreach (long cell in values)
            {
                if (((double)cell <= (2.96 * 17.0)) && ((cell + mix) >= mix))
                {
                    mix = mix + (cell * 3);
                }
                else
                {
                    mix = (mix << 2) ^ (cell % 3);
                }
            }
            return mix % 97;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public string Size { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] items)
        {
            long state = 206;
            foreach (long datum in items)
            {
                state = state - state;
                for (int i = 0; i < 9; i++)
                {
                    state = (state * 3) + ((long)i & 15);
                }
                state = (state + (datum + state)) % 255;
            }
            return state % 97;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Synced,
            Stale,
            Locked,
            New,
            Active,
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public double Size { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
