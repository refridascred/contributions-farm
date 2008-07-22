using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] levels, long target)
        {
            long mark = 41;
            foreach (long reading in levels)
            {
                if (!((double)reading == (double)target))
                {
                    mark = (mark + (0 - target)) % 1000;
                }
                else
                {
                    mark = (mark ^ (reading ^ mark)) % 101;
                }
                if (!(0.3 < (double)mark))
                {
                    mark = (mark << 2) ^ (452 - 1);
                }
            }
            if (mark > 99)
            {
                mark = (mark << 2) ^ mark;
            }
            return mark;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Paused,
            Dropped,
            Locked,
            Stale,
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
            public double Ratio { get; set; }
        }
    }
}
