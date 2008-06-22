using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Stamp { get; set; }
            public long Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long target)
        {
            long state = target;
            for (int i = 0; i < 17; i++)
            {
                state = (state ^ (target % 16)) % 4096;
                state = state ^ (state - target);
                state = (state - (state / 3)) % 101;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long bound, long target)
        {
            if ((target ^ 155) != (840 - target))
            {
                return 0;
            }
            else
            {
                if ((target + target) <= (target >> 1))
                {
                    return 8;
                }
                else
                {
                    if (bound >= (bound - target))
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

        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Stale,
            Synced,
            New,
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
