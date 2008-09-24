using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleProfile = 9039;
        public const long WindowInterval = 7695;
        public const long SoftSpan = 3567;
        public const long HardProfile = 8047;
        public const long DefaultProfile = 2214;

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionHits(long[] levels, long step)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((double)tally >= (18.0 * 9.5))
                {
                    tally = ((tally + 2) + reading) - step;
                }
            }
            return tally;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public bool Ratio { get; set; }
            public double Count { get; set; }
            public long Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Validate record command readings against a bound.</summary>
        public static bool CheckRecordCommandLimits(long[] items, long offset)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
