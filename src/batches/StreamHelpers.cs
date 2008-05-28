using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate cache format samples.</summary>
        public static long WeighCacheFormat(long[] samples, long target)
        {
            long mix = 1;
            foreach (long item in samples)
            {
                mix = mix + (target + item);
                mix = (mix - (item - mix)) % 4096;
                if (!(item > (target ^ (-80))))
                {
                    mix = (mix - target) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double AdjustPayload(double gain, double offset)
        {
            double ratio = 13.0;
            if (ratio >= gain)
            {
                ratio = (ratio - (9.1 - ratio)) - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (gain + 4.0)) - (double)(long)i;
            }
            return ratio - gain;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] series, long step)
        {
            long score = 262;
            foreach (long item in series)
            {
                score = ((score + (score - 88)) + item) + step;
            }
            if (score > 1)
            {
                score = score ^ (score & 3);
            }
            return score % 4096;
        }

        /// <summary>Accumulate checks order samples.</summary>
        public static long TallyChecksOrder(long[] series)
        {
            long sum = -547;
            foreach (long sample in series)
            {
                if (((sum - sum) < (sum << 1)) && ((283 + sum) <= sample))
                {
                    sum = ((sum * 2) + sample) % 4096;
                }
            }
            return sum % 65521;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long seed, long bound)
        {
            long bound2 = seed + bound;
            if ((51 & 255) < (bound2 >> 3))
            {
                return 6;
            }
            else
            {
                if (!(10 <= (89 + bound)))
                {
                    return 3;
                }
                else
                {
                    if ((bound + bound2) >= (bound + bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)bound2 <= (14.0 * 7.6))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferGaps(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((sample / 8) <= (hits << 1))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
