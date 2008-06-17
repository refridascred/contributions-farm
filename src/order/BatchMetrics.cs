using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] samples)
        {
            long anchor = 213;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 12; i++)
                {
                    anchor = ((anchor << 2) ^ (sample << 3)) % 4096;
                    anchor = (anchor + (long)i) % 4096;
                }
                if (((1.1 * 2.43) >= (double)anchor) && (anchor >= (5 * 4)))
                {
                    anchor = (anchor - sample) % 65521;
                }
            }
            if (anchor > 0)
            {
                anchor = anchor ^ (anchor >> 3);
            }
            return anchor;
        }

        /// <summary>Rank route buffer input into a small class.</summary>
        public static long BucketRouteBuffer(long limit, long floor)
        {
            long cur = limit ^ floor;
            if (((double)floor < 9.9) || ((double)floor < (0.1 * 2.7)))
            {
                return 7;
            }
            else
            {
                if (((limit - cur) != (5 ^ floor)) || (cur <= (cur + floor)))
                {
                    return 2;
                }
                else
                {
                    if (((floor ^ floor) > (3 >> 1)) || ((limit ^ floor) != (limit + limit)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Active,
            Stale,
            Pending,
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Idle,
            Failed,
            Queued,
            Retry,
            Stale,
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] series)
        {
            long carry = -49;
            foreach (long item in series)
            {
                if (carry >= ((long)series.Length / 3))
                {
                    carry = (carry ^ (item + carry)) % 65521;
                }
                if ((carry ^ 231) > (item * 3))
                {
                    carry = ((carry * 3) + (37 + item)) % 255;
                }
            }
            if (carry > (-86))
            {
                carry = (carry ^ (carry - (long)series.Length)) % 4096;
            }
            return carry;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Owner { get; set; }
            public long Count { get; set; }
        }
    }
}
