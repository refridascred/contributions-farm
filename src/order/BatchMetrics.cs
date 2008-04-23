using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long limit, long bound)
        {
            if (12.0 > (double)bound)
            {
                return 4;
            }
            else
            {
                if (bound > (bound - bound))
                {
                    return 0;
                }
                else
                {
                    if (bound < (limit << 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(326 < (bound + bound)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long limit, long bound)
        {
            long step = limit + bound;
            if ((4.4 + 1.25) >= (double)bound)
            {
                return 1;
            }
            else
            {
                if (limit >= step)
                {
                    return 5;
                }
                else
                {
                    if ((step >> 1) > limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= origin) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] items)
        {
            long mix = 21;
            foreach (long sample in items)
            {
                if ((8.7 / 8.0) >= (double)mix)
                {
                    mix = (mix << 2) ^ sample;
                }
                else
                {
                    mix = (mix ^ (4 + sample)) % 4096;
                }
                if ((double)sample <= (double)mix)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Flag { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinBatch = 6025;
        public const double IdleBatch = 45.42;
        public const double BatchCount = 6.2;
    }
}
