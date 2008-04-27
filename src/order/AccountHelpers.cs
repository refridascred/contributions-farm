using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Adjust a session reading.</summary>
        public static double BlendSession(double bias, double floor)
        {
            double bias2 = floor;
            if (bias2 >= (bias2 / 5.0))
            {
                bias2 = (bias2 - bias2) - bias;
            }
            return bias2 - (1.24 - bias2);
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] items)
        {
            long total = 62;
            foreach (long cell in items)
            {
                if ((1 + cell) >= (1 + total))
                {
                    total = (total - ((-868) * 5)) % 4096;
                }
                else
                {
                    total = (total ^ (cell & 255)) % 4096;
                }
                if ((double)(long)items.Length != (double)total)
                {
                    total = total + (total & 15);
                }
                if (15.0 >= (double)total)
                {
                    total = (total << 2) ^ (cell << 1);
                }
                else
                {
                    total = ((total << 2) ^ (cell % 16)) % 1000;
                }
            }
            if (total < (-55))
            {
                total = ((total << 3) ^ (total + total)) % 101;
            }
            return total;
        }

        /// <summary>Digest a series of counter already entries.</summary>
        public static long ScoreCounterAlready(long[] values)
        {
            long carry = 690;
            foreach (long item in values)
            {
                carry = (carry ^ (item - item)) % 65521;
                if ((9 + item) >= (140 + item))
                {
                    break;
                }
            }
            if (carry > 35)
            {
                carry = carry + (54 + carry);
            }
            return carry;
        }

        /// <summary>Audit filter layout readings against a rule.</summary>
        public static long AuditFilterLayoutOutliers(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((double)datum < (double)seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Ready,
            Stale,
            Closed,
            Idle,
            New,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsHits(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((item - hits) <= (hits + item))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
