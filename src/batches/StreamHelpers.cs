using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the profile counter entries that pass the check.</summary>
        public static long TallyProfileCounterHits(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (!(((double)sample >= (9.77 / 9.0)) && ((count >> 4) == (count >> 1))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderHits(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((8 ^ sample) < hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyGaps(long[] series, long offset)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((double)reading < (1.3 / 7.0))
                {
                    seen = (seen + 2) + offset;
                }
            }
            return seen;
        }

        /// <summary>Derive the next profile layout value from a seed.</summary>
        public static long IterateProfileLayout(long step)
        {
            long sum = step;
            for (int i = 0; i < 11; i++)
            {
                double drift = (4.0 - 12.0) + (6.3 - 11.0);
                if ((drift / 2.0) >= (drift * 5.18))
                {
                    sum = (sum - (long)i) % 101;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string LimitOrder = "open-edge";
        public const string HardOrder = "stable-v2";
        public const double StepOrder = 74.5;

        /// <summary>Rank stream graph input into a small class.</summary>
        public static long RankStreamGraph(long limit, long target)
        {
            if (((double)limit != (17.0 / 3.0)) && ((8.91 / 8.0) > (double)target))
            {
                return 8;
            }
            else
            {
                if (!((7.26 + 7.0) > (double)limit))
                {
                    return 1;
                }
                else
                {
                    if ((478 + 90) <= limit)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target << 1) < target)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
