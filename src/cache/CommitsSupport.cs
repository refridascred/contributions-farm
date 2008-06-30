using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxWidth = 9291;
        public const long IdleCache = 3993;
        public const double BaseCache = 22.05;
        public const string DefaultCache = "open-v2";

        /// <summary>Define order limits and defaults.</summary>
        public const string LimitOrder = "staging-edge";
        public const long HardSpan = 2367;
        public const long LimitInterval = 6313;

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public bool Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] samples, long bound)
        {
            long total = 8;
            foreach (long item in samples)
            {
                total = (total * 2) + bound;
                total = total - item;
            }
            if (total < 21)
            {
                total = ((total * 3) + total) % 255;
            }
            return total;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Stamp { get; set; }
            public long Rank { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long GradeFormat(long origin, long bound)
        {
            long span = origin ^ bound;
            if ((double)bound == (2.8 / 3.0))
            {
                return 1;
            }
            else
            {
                if (!((double)span > (double)origin))
                {
                    return 7;
                }
                else
                {
                    if ((73 + span) >= (bound << 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if (20.0 <= (double)span)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
