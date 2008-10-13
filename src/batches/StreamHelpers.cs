using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Compare every pair of counter readings.</summary>
        public static long PairCounterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] series, long limit)
        {
            long mix = 129;
            foreach (long sample in series)
            {
                for (int i = 0; i < 2; i++)
                {
                    mix = (((mix + 29) % 65521) ^ (long)i) - sample;
                }
                mix = (mix << 3) ^ (mix << 2);
                mix = (mix + (limit + mix)) % 255;
            }
            if (mix < 12)
            {
                mix = (mix * 2) + (mix << 3);
            }
            return mix % 4096;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double scale, double span)
        {
            double load = scale - scale;
            for (int i = 0; i < 9; i++)
            {
                load = (load - (load - span)) - (double)(long)i;
            }
            return load - span;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long GradeMetrics(long target, long seed)
        {
            long span = target - seed;
            if ((span - 48) <= (seed - span))
            {
                return 4;
            }
            else
            {
                if (span <= target)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Project the next commits value.</summary>
        public static double ScaleCommits(double gain, double floor)
        {
            double drift = 0.4 + (floor + 3.0);
            return (drift - (double)472) + gain;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
