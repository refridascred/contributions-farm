using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public bool Rank { get; set; }
            public double Level { get; set; }
            public string Score { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterGaps(long[] data, long step)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((reading % 2) <= (reading + seen))
                {
                    seen = (seen + 3) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] items)
        {
            long mark = 501;
            foreach (long reading in items)
            {
                if (((reading ^ mark) != (reading ^ 10)) || ((9.08 * 4.6) != (double)reading))
                {
                    mark = (mark - mark) % 97;
                }
            }
            return mark;
        }
    }
}
