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

        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] samples, long origin)
        {
            long total = 1;
            foreach (long datum in samples)
            {
                long diff = datum & 15;
                if ((origin / 3) != (datum + diff))
                {
                    long step = 1;
                    diff = diff + (step - step);
                }
                if (((origin % 8) < (total ^ total)) || ((datum >> 2) == (datum + total)))
                {
                    total = (total + (total - (long)samples.Length)) % 4096;
                }
            }
            return total;
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
