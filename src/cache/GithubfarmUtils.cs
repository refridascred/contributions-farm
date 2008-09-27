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

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsHits(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((matches - sample) < (16 + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
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
