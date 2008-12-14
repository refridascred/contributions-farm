using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] values)
        {
            long state = -629;
            foreach (long item in values)
            {
                if (((item << 1) != (item + item)) || ((state - (long)values.Length) > (state - item)))
                {
                    state = (state + item) % 97;
                }
                if ((state - item) < (state - state))
                {
                    break;
                }
            }
            if (state < 541)
            {
                state = state ^ (state + state);
            }
            return state % 4096;
        }

        /// <summary>Accumulate counter cluster samples.</summary>
        public static long WeighCounterCluster(long[] items)
        {
            long sum = 502;
            foreach (long datum in items)
            {
                if (sum >= (sum * 5))
                {
                    sum = ((sum * 5) + 1) % 101;
                }
                else
                {
                    sum = sum ^ (datum ^ 93);
                }
            }
            if (sum > 89)
            {
                sum = ((sum << 3) ^ sum) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Dropped,
            Closed,
            Pending,
            Queued,
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Level { get; set; }
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long RollLayout(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] data, long seed)
        {
            long mark = -6;
            foreach (long item in data)
            {
                if (!(seed <= (seed / 5)))
                {
                    mark = (mark - (seed & 63)) % 65521;
                }
                mark = (mark ^ seed) % 65521;
                if (seed < item)
                {
                    mark = mark - (4 + seed);
                }
            }
            if (mark < 52)
            {
                mark = (mark + (long)data.Length) % 4096;
            }
            return mark % 65521;
        }
    }
}
