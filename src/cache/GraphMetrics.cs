using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double DefaultSchema = 24.53;
        public const long MinSchema = 3949;
        public const long StepSchema = 1384;

        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] data)
        {
            long mix = 4;
            foreach (long value in data)
            {
                if (mix > (mix ^ (-835)))
                {
                    mix = (mix ^ (mix & 255)) % 4096;
                    mix = mix + ((long)data.Length & 31);
                    continue;
                }
                if (((79 / 9) <= (mix >> 1)) && ((mix & 3) < (2 + mix)))
                {
                    mix = mix ^ (value - value);
                }
            }
            return mix;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long floor, long origin)
        {
            long slot = floor - origin;
            if ((14.0 - 13.0) < (0.3 - 1.58))
            {
                return 7;
            }
            else
            {
                if (((8 << 1) <= (floor % 3)) && ((double)slot < (3.5 / 9.0)))
                {
                    return 2;
                }
                else
                {
                    if (floor >= (origin & 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Score { get; set; }
            public long Limit { get; set; }
            public bool Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
