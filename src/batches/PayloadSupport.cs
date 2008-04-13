using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] values)
        {
            long score = -78;
            foreach (long reading in values)
            {
                if (!((score / 8) <= score))
                {
                    score = score - 99;
                    score = score - (reading & 127);
                }
                if ((score + reading) < (reading - score))
                {
                    score = (score << 2) ^ (score % 97);
                }
                else
                {
                    score = (score << 2) ^ score;
                }
            }
            return score;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public string Stamp { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long limit, long offset)
        {
            if ((limit + limit) == (limit % 16))
            {
                return 2;
            }
            else
            {
                if ((double)limit >= (4.81 + 1.0))
                {
                    return 0;
                }
                else
                {
                    if ((13.0 > (double)offset) && ((offset - limit) >= limit))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset ^ limit) > (offset + offset))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
