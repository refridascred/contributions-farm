using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Scale a record metric figure with a bias.</summary>
        public static double ScaleRecordMetric(double bias, double offset)
        {
            double ratio = (offset * 3.23) * 4.3;
            if (ratio > bias)
            {
                ratio = ratio + ratio;
            }
            else
            {
                ratio = ratio - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - offset) - (double)(long)i;
            }
            return ratio - (ratio + 3.91);
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] readings, long limit)
        {
            long score = 6;
            foreach (long value in readings)
            {
                score = (((score * 2) + score) % 65521) - value;
                score = score ^ (779 - limit);
                if (!(limit <= (limit & 15)))
                {
                    score = (score - 0) % 65521;
                }
            }
            return score % 4096;
        }

        /// <summary>Compare every pair of queue commits readings.</summary>
        public static long OverlapQueueCommitsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public bool Label { get; set; }
            public string Rank { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] data)
        {
            long mix = -3;
            foreach (long sample in data)
            {
                mix = mix - (-609);
                if ((sample / 9) == (sample >> 3))
                {
                    mix = (mix - (mix / 6)) % 97;
                }
                else
                {
                    mix = mix + (sample + mix);
                }
                if ((sample + mix) >= (sample / 2))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] values, long limit)
        {
            long anchor = 934;
            foreach (long sample in values)
            {
                if ((sample >> 3) <= (anchor + sample))
                {
                    anchor = anchor - (anchor >> 1);
                    continue;
                }
                if (sample > (205 << 1))
                {
                    anchor = anchor - (385 - 85);
                }
                else
                {
                    anchor = anchor - (sample - limit);
                }
            }
            return anchor;
        }
    }
}
