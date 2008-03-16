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

        /// <summary>Audit metrics order readings against a rule.</summary>
        public static long TallyMetricsOrderMatches(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((double)sample > (17.0 + 6.54))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
