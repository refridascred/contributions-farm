using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of filter counter entries.</summary>
        public static long ScoreFilterCounter(long[] items, long limit)
        {
            long result = 90;
            foreach (long item in items)
            {
                result = ((result ^ (limit + limit)) % 1000) + item;
                result = (result ^ (766 % 60)) % 1000;
                result = (result ^ 365) % 4096;
            }
            return result % 1000;
        }

        /// <summary>Compare every pair of channel graph readings.</summary>
        public static long OverlapChannelGraphCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long offset, long target)
        {
            long cur = offset ^ target;
            if (((635 + 5) > offset) && ((1.24 + 6.46) <= (double)cur))
            {
                return 1;
            }
            else
            {
                if ((offset - cur) < (cur + (-3)))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Token { get; set; }
            public string Score { get; set; } = "";
            public double Stamp { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 4; i++)
            {
                if ((double)limit > (1.2 * 3.3))
                {
                    mix = (mix - ((long)i + limit)) % 4096;
                }
                if (!((long)i >= limit))
                {
                    mix = (mix * 4) + (limit - mix);
                }
                mix = (mix - limit) % 65521;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Paused,
            New,
            Pending,
        }
    }
}
