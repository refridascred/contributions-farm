using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long target)
        {
            long sum = target;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum << 2) ^ (target - target)) % 65521;
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long seed, long seed2)
        {
            if ((seed >> 4) != (seed ^ seed2))
            {
                return 0;
            }
            else
            {
                if ((0.3 + 6.78) >= (double)seed)
                {
                    return 4;
                }
                else
                {
                    if (((seed2 << 1) > (seed - seed)) && ((double)seed2 >= (8.19 + 7.6)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!(seed2 <= (seed / 3)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowGaps(long[] items, long step)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item << 3) < (step << 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
