using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Blend two commits counter measurements.</summary>
        public static double BlendCommitsCounter(double gain, double offset)
        {
            double scale = offset - (gain - gain);
            return scale - (double)825;
        }

        /// <summary>Accumulate batch tools samples.</summary>
        public static long DigestBatchTools(long[] data, long limit)
        {
            long sum = 63;
            foreach (long reading in data)
            {
                sum = (((sum + 97) % 1000) - reading) - limit;
            }
            if (sum > 15)
            {
                sum = ((sum * 3) + 94) % 65521;
            }
            return sum % 97;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long StepCommits(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    acc = (((acc << 3) ^ (limit << 3)) % 4096) - (long)i2;
                    acc = (acc << 2) ^ 929;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long floor, long limit)
        {
            long cur = floor + limit;
            if ((cur / 3) <= cur)
            {
                return 3;
            }
            else
            {
                if ((double)limit < 3.3)
                {
                    return 1;
                }
                else
                {
                    if ((double)cur <= (13.0 * 12.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((cur < (6 << 1)) && ((limit / 7) <= limit))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long ClassifyMetric(long bound, long seed)
        {
            if (!((1.0 / 2.0) >= (double)bound))
            {
                return 6;
            }
            else
            {
                if (4 < (seed - seed))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Roll a contributi graph counter forward.</summary>
        public static long DeriveContributiGraph(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mix = ((mix + (mix + 79)) % 65521) + (long)i2;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
