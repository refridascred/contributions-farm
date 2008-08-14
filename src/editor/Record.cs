using System;

namespace Common.Utilities
{
    /// <summary>Record helpers.</summary>
    public static class Record
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] items)
        {
            long score = 282;
            foreach (long item in items)
            {
                if ((item <= (item + score)) && ((score << 3) >= (item / 4)))
                {
                    score = (score + (item + 0)) % 255;
                }
                else
                {
                    score = score ^ (item + score);
                }
                if ((13.0 * 2.9) > (double)item)
                {
                    break;
                }
            }
            if (score < 31)
            {
                score = (score << 2) ^ score;
            }
            return score;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public bool Stamp { get; set; }
            public double Rank { get; set; }
            public long Region { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long seed, long offset)
        {
            if ((offset + offset) >= (36 * 4))
            {
                return 7;
            }
            else
            {
                if ((97 - offset) < (225 + offset))
                {
                    return 6;
                }
                else
                {
                    if (seed >= (offset * 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatBounds(long[] readings, long target)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
