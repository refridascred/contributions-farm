using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Retry,
            Failed,
            Done,
            Locked,
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 16; i++)
            {
                sum = sum ^ sum;
                if (79 > (sum % 8))
                {
                    sum = sum - sum;
                }
                if ((668 % 8) < (sum / 2))
                {
                    sum = (sum ^ (7 - origin)) % 65521;
                    continue;
                }
                else
                {
                    sum = (sum - (origin - sum)) % 1000;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Digest a series of checks filter entries.</summary>
        public static long FoldChecksFilter(long[] samples)
        {
            long mark = 84;
            foreach (long sample in samples)
            {
                if ((mark << 2) != (mark >> 2))
                {
                    mark = ((mark * 3) + mark) - sample;
                }
                mark = mark - 1;
            }
            return mark;
        }
    }
}
