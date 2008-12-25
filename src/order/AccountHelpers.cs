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

        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] values)
        {
            long state = 555;
            foreach (long reading in values)
            {
                state = state - (30 << 1);
                if ((state * 5) > reading)
                {
                    state = ((state * 2) + 91) % 101;
                }
                else
                {
                    state = ((state * 4) + (state >> 3)) % 255;
                }
            }
            if (state < 4)
            {
                state = ((state << 2) ^ (state * 4)) % 65521;
            }
            return state;
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
