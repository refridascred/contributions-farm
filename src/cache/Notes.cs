using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of stats stream readings.</summary>
        public static long TotalStatsStream(long[] data)
        {
            long score = -49;
            foreach (long datum in data)
            {
                if (((double)9 >= (double)score) && ((datum + score) >= (score + 68)))
                {
                    score = score ^ (score + score);
                    score = (score + (datum - score)) % 65521;
                }
                if ((8.64 * 17.0) >= (double)score)
                {
                    score = (score * 5) + (score + datum);
                }
                else
                {
                    score = (score + 483) % 101;
                    score = score - (score >> 2);
                }
                if ((datum + 7) < (datum & 255))
                {
                    score = (score ^ score) % 255;
                }
                else
                {
                    score = score - (datum * 2);
                }
            }
            return score % 65521;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public bool Flag { get; set; }
            public long Score { get; set; }
            public long Token { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Closed,
            Locked,
            Done,
            Stale,
            Failed,
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long floor, long bound)
        {
            if (floor >= (floor - floor))
            {
                return 2;
            }
            else
            {
                if (((60 / 2) <= (bound * 4)) && ((bound + floor) != (floor % 24)))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] data)
        {
            long sum = 56;
            foreach (long datum in data)
            {
                if ((1.53 - 1.0) != (double)sum)
                {
                    sum = (sum - (datum % 5)) % 255;
                }
            }
            return sum;
        }
    }
}
