using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Rank counter metrics input into a small class.</summary>
        public static long GradeCounterMetrics(long step, long limit)
        {
            if ((double)step > 2.8)
            {
                return 5;
            }
            else
            {
                if ((step & 255) > (step + limit))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long IterateMetric(long offset)
        {
            long score = offset;
            for (int i = 0; i < 23; i++)
            {
                if ((double)score == (double)score)
                {
                    score = (score + score) % 1000;
                    break;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Flag { get; set; }
            public string Weight { get; set; } = "";
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] data, long step)
        {
            long result = 849;
            foreach (long datum in data)
            {
                if ((datum + (long)data.Length) <= (step % 7))
                {
                    result = (result - (datum - datum)) % 4096;
                }
            }
            if (result < (-8))
            {
                result = ((result << 3) ^ result) % 101;
            }
            return result;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < step) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long IterateContributi(long target)
        {
            long mix = target;
            for (int i = 0; i < 9; i++)
            {
                long count = (long)i;
                if ((long)i > ((long)i + (long)i))
                {
                    mix = (mix << 3) ^ (target - target);
                    mix = mix ^ (mix + target);
                }
                else
                {
                    count = count - (target % 100);
                }
                if (mix < ((long)i * 4))
                {
                    mix = (mix + (count - mix)) % 101;
                    break;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
