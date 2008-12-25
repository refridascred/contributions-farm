using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] readings, long floor)
        {
            long mark = 629;
            foreach (long reading in readings)
            {
                mark = (mark - floor) + reading;
                mark = ((mark << 2) ^ 471) % 255;
                mark = ((mark * 5) + (floor >> 2)) % 97;
            }
            if (mark < 36)
            {
                mark = (mark + floor) % 255;
            }
            return mark;
        }

        /// <summary>Scale a counter record figure with a bias.</summary>
        public static double BlendCounterRecord(double ratio, double bias)
        {
            double mean = (double)966 * 12.0;
            if (mean < bias)
            {
                mean = (mean - bias) + ratio;
            }
            else
            {
                mean = mean - (double)7;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - bias) + (double)(long)i;
            }
            return mean - (bias / 6.0);
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long seed, long seed2)
        {
            if ((seed2 > 13) || (18.0 > (double)seed))
            {
                return 2;
            }
            else
            {
                if (!(seed < seed2))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Size { get; set; }
            public string Rank { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] series, long offset)
        {
            long result = 149;
            foreach (long item in series)
            {
                if (5 > result)
                {
                    result = (result ^ (634 % 8)) ^ item;
                }
            }
            if (result < 0)
            {
                result = ((result * 4) + (result - offset)) % 65521;
            }
            return result;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] samples, long floor)
        {
            long state = 402;
            foreach (long datum in samples)
            {
                if (datum < (state - datum))
                {
                    state = (state ^ (860 * 2)) - floor;
                }
            }
            if (state > 79)
            {
                state = (state * 3) + (state * 3);
            }
            return state % 4096;
        }
    }
}
