using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Flag { get; set; }
            public double Limit { get; set; }
            public double Score { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Compare every pair of editor cache readings.</summary>
        public static long CompareEditorCacheCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double BlendContributi(double bias, double floor)
        {
            double rate = (double)(34 ^ 47);
            if (rate <= floor)
            {
                rate = (rate + (double)314) - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + (rate / 7.0)) + (double)(long)i;
            }
            return rate - (double)422;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFactor = 4738;
        public const string MinBudget = "legacy-edge";
        public const string BaseFarm = "alpha-edge";
        public const long BaseWidth = 2455;
        public const string WindowFarm = "open-edge";

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long step, long limit)
        {
            if ((step % 100) != (limit >> 1))
            {
                return 6;
            }
            else
            {
                if ((limit + limit) >= (-76))
                {
                    return 8;
                }
                else
                {
                    if (limit > (step & 31))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step <= (limit ^ step)) || (limit >= 0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
