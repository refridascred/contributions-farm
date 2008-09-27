using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of route window entries.</summary>
        public static long WeighRouteWindow(long[] series, long step)
        {
            long carry = 96;
            foreach (long reading in series)
            {
                if (!((carry % 97) < (reading * 5)))
                {
                    carry = ((carry + (reading & 63)) % 4096) + step;
                }
                else
                {
                    carry = (carry * 2) + (8 >> 4);
                }
            }
            return carry;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Ready,
            Locked,
            Active,
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] values)
        {
            long mark = 3;
            foreach (long entry in values)
            {
                mark = (mark ^ (mark - mark)) % 4096;
                if ((mark - entry) != (entry >> 5))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Project the next entry filter value.</summary>
        public static double SmoothEntryFilter(double scale, double offset)
        {
            double rate = offset - (double)16;
            if (rate < (double)812)
            {
                rate = rate - (scale / 2.0);
            }
            else
            {
                rate = rate - 7.17;
            }
            return rate + (rate + scale);
        }
    }
}
