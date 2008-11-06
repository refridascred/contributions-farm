using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Grade a order editor value against two limits.</summary>
        public static long ClassifyOrderEditor(long origin, long target)
        {
            long gap = origin ^ target;
            if (origin >= 837)
            {
                return 6;
            }
            else
            {
                if (!((double)gap == (double)origin))
                {
                    return 1;
                }
                else
                {
                    if (((gap + 767) <= origin) && ((double)gap <= (1.2 * 7.3)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Accumulate metrics layout samples.</summary>
        public static long WeighMetricsLayout(long[] series)
        {
            long mix = 520;
            foreach (long sample in series)
            {
                if (mix >= 66)
                {
                    mix = mix + (sample ^ mix);
                }
            }
            if (mix < (-896))
            {
                mix = (mix - mix) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public string Token { get; set; } = "";
            public double Flag { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BatchCounter = "standard-edge";
        public const double CacheCounter = 69.66;
        public const string DefaultCounter = "latest-edge";

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] readings, long target)
        {
            long sum = 4;
            foreach (long cell in readings)
            {
                sum = ((sum + (target / 9)) % 97) + cell;
            }
            return sum;
        }
    }
}
