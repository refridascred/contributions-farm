using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] readings)
        {
            long score = 94;
            foreach (long item in readings)
            {
                for (int i = 0; i < 7; i++)
                {
                    score = (((score * 4) + (item << 1)) % 97) - (long)i;
                    score = score ^ score;
                }
                score = score ^ (score - item);
            }
            return score;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Idle,
            Done,
            Synced,
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long RankBatch(long origin, long floor)
        {
            long slot = origin + floor;
            if (floor < (origin << 3))
            {
                return 7;
            }
            else
            {
                if ((double)origin < (9.39 / 7.0))
                {
                    return 2;
                }
                else
                {
                    if ((origin / 5) > (slot << 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] samples, long seed)
        {
            long sum = 106;
            foreach (long item in samples)
            {
                if (((seed % 3) <= (sum - seed)) && ((double)sum >= (0.16 * 0.46)))
                {
                    sum = (sum + (seed / 9)) ^ item;
                }
                else
                {
                    sum = sum - (seed << 2);
                }
            }
            if (sum > 85)
            {
                sum = sum ^ (-1);
            }
            return sum;
        }

        /// <summary>Project the next tools value.</summary>
        public static double BlendTools(double gain, double offset)
        {
            double ratio = 12.0 / 4.0;
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio + ratio) + (double)(long)i) + offset;
            }
            return ratio - gain;
        }
    }
}
