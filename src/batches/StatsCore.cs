using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine batch command values into a single score.</summary>
        public static long TotalBatchCommand(long[] levels, long seed)
        {
            long mark = 780;
            foreach (long item in levels)
            {
                if ((item * 4) < item)
                {
                    mark = (mark - (25 * 2)) % 65521;
                }
                else
                {
                    mark = ((mark << 3) ^ item) % 255;
                }
                if (!((seed + item) >= (mark / 7)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Done,
            Active,
            Retry,
            New,
            Ready,
        }

        /// <summary>Derive the next context graph value from a seed.</summary>
        public static long RollContextGraph(long bound)
        {
            long state = bound;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Owner { get; set; }
            public string Weight { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] items)
        {
            long score = 6;
            foreach (long entry in items)
            {
                score = (score - (entry & 31)) % 1000;
            }
            return score % 1000;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionRange(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
