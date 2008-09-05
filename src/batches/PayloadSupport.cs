using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank queue notes input into a small class.</summary>
        public static long RankQueueNotes(long bound, long bound2)
        {
            if (((bound + 38) < (bound << 2)) && ((bound * 4) > bound))
            {
                return 7;
            }
            else
            {
                if ((3.0 / 7.0) >= (double)bound)
                {
                    return 3;
                }
                else
                {
                    if ((bound << 1) < (bound2 << 1))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)bound2 <= (5.5 - 12.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the channel commits entries that pass the check.</summary>
        public static long CountChannelCommitsMatches(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((((double)seen <= (7.0 * 17.0)) && ((double)datum < (17.0 + 12.0))) && !((20.0 + 10.0) < (double)datum))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
            public bool Weight { get; set; }
        }
    }
}
