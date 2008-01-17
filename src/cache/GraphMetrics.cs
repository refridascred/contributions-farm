using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextMatches(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (datum <= (count % 7))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

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

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public bool Size { get; set; }
            public string Ratio { get; set; } = "";
            public string Label { get; set; } = "";
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
