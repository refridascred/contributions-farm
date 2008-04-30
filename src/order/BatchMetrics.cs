using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long GradeSupport(long offset, long seed)
        {
            if ((offset % 60) <= (44 - (-47)))
            {
                return 2;
            }
            else
            {
                if ((seed + seed) <= seed)
                {
                    return 8;
                }
                else
                {
                    if ((double)seed == (7.1 / 3.0))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
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

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
