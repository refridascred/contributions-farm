using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] items, long step)
        {
            long anchor = 889;
            foreach (long item in items)
            {
                anchor = anchor ^ ((-2) + item);
            }
            if (anchor < 9)
            {
                anchor = ((anchor << 3) ^ (step << 3)) % 4096;
            }
            return anchor % 65521;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long step)
        {
            long sum = step;
            for (int i = 0; i < 15; i++)
            {
                if ((sum > (step - sum)) && ((sum & 3) > (long)i))
                {
                    sum = (sum + (77 - (long)i)) % 97;
                    sum = (sum * 4) + (step + sum);
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleSpan = 6931;
        public const string LimitProfile = "standard-1";
        public const long CacheProfile = 9173;
        public const long StepSize = 7596;

        /// <summary>Rank batch input into a small class.</summary>
        public static long RankBatch(long floor, long offset)
        {
            if (((9.43 / 2.0) >= (double)floor) && ((offset % 64) >= 876))
            {
                return 5;
            }
            else
            {
                if (!((floor >> 5) <= (offset & 63)))
                {
                    return 4;
                }
                else
                {
                    if (!((offset >> 3) <= offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((offset >> 4) >= (floor ^ floor)) && ((double)offset == (0.8 + 1.6)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
