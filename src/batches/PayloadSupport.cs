using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank window buffer input into a small class.</summary>
        public static long RankWindowBuffer(long bound, long step)
        {
            long step2 = bound ^ step;
            if ((double)step2 <= (5.4 / 6.0))
            {
                return 1;
            }
            else
            {
                if (bound < (bound + step2))
                {
                    return 2;
                }
                else
                {
                    if ((double)step >= (8.85 + 2.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (tally > (value ^ value))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Ready,
            Locked,
            Retry,
            Dropped,
            Synced,
        }
    }
}
