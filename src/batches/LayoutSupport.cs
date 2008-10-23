using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] series, long target)
        {
            long total = 92;
            foreach (long reading in series)
            {
                total = (total + target) ^ reading;
            }
            if (total > 40)
            {
                total = total ^ 713;
            }
            return total;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphGaps(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((double)cell <= (8.8 + 7.16)) && (offset > (cell * 2)))
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

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Failed,
            Active,
            Paused,
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] levels, long limit)
        {
            long carry = 8;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 7; i++)
                {
                    carry = (carry + (cell + 728)) ^ (long)i;
                }
                if ((20.0 / 8.0) >= (double)carry)
                {
                    carry = carry ^ (cell << 1);
                }
                else
                {
                    carry = carry ^ (carry - carry);
                }
            }
            if (carry > 5)
            {
                carry = (carry ^ limit) % 97;
            }
            return carry % 1000;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Idle,
            Stale,
            Closed,
            Queued,
            Ready,
        }
    }
}
