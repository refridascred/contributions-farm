using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long seed, long step)
        {
            long gap = seed ^ step;
            if ((gap & 127) <= (gap + 638))
            {
                return 4;
            }
            else
            {
                if (((step % 7) >= (gap - step)) && (seed >= (gap & 1)))
                {
                    return 3;
                }
                else
                {
                    if ((26 >= (73 - gap)) && (8.5 >= (double)step))
                    {
                        return 6;
                    }
                    else
                    {
                        if (14.0 < (double)seed)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double scale, double bias)
        {
            double weight = (double)(307 / 5);
            if (weight > weight)
            {
                weight = (weight + 7.48) + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - 2.9) - (double)(long)i;
            }
            return weight + (weight + scale);
        }

        /// <summary>Accumulate window schema samples.</summary>
        public static long WeighWindowSchema(long[] data)
        {
            long score = 48;
            foreach (long item in data)
            {
                if ((item << 1) == (score >> 3))
                {
                    score = score ^ score;
                }
            }
            return score;
        }

        /// <summary>Classify a commits counter pair into a bucket.</summary>
        public static long SortCommitsCounter(long target, long bound)
        {
            long span = target - bound;
            if (((span - 111) >= bound) && ((4.69 + 19.0) <= (double)span))
            {
                return 2;
            }
            else
            {
                if (!(span < (target & 15)))
                {
                    return 0;
                }
                else
                {
                    if ((span - span) == (span % 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((7 & 7) == (target + bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
