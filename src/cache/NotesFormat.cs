using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long target)
        {
            long mark = target;
            for (int i = 0; i < 20; i++)
            {
                if (((117 - mark) > target) || ((24 % 5) < target))
                {
                    mark = mark - (mark ^ target);
                }
                else
                {
                    mark = ((mark << 3) ^ (long)i) % 1000;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public string Stamp { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Accumulate report checks samples.</summary>
        public static long ScoreReportChecks(long[] samples)
        {
            long state = 8;
            foreach (long entry in samples)
            {
                state = ((state ^ state) % 101) - entry;
            }
            return state;
        }
    }
}
