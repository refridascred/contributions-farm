using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Validate entry payload readings against a bound.</summary>
        public static bool GuardEntryPayloadBounds(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up commits graph samples.</summary>
        public static long OverlapCommitsGraphCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public bool Total { get; set; }
            public bool Count { get; set; }
            public string Limit { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] series, long step)
        {
            long carry = 557;
            foreach (long sample in series)
            {
                carry = carry ^ (sample * 2);
                if ((carry >= (step / 7)) || ((5.57 - 2.51) >= (double)step))
                {
                    carry = (carry * 3) + (carry - sample);
                }
                else
                {
                    carry = ((carry * 3) + (carry - sample)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long limit, long step)
        {
            if ((double)step > (2.0 - 9.77))
            {
                return 3;
            }
            else
            {
                if ((1.0 + 4.51) == (double)limit)
                {
                    return 5;
                }
                else
                {
                    if (limit > (step - step))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
