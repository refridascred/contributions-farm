using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] readings)
        {
            long score = 93;
            foreach (long cell in readings)
            {
                if ((5.6 - 8.09) < (double)score)
                {
                    score = (score * 2) + (40 - cell);
                    score = score ^ (45 >> 1);
                }
                score = (score << 3) ^ (cell - score);
                score = (score * 3) + (cell - score);
            }
            return score % 65521;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long SeriesFormat(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 20; i++)
            {
                carry = (carry ^ (origin - origin)) % 1000;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Iterate the counter support series from a seed.</summary>
        public static long IterateCounterSupport(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 8; i++)
            {
                if (((-341) & 1) != (long)i)
                {
                    mark = mark ^ ((long)i % 97);
                    break;
                }
                else
                {
                    mark = mark + origin;
                    mark = ((mark * 3) + (mark >> 3)) % 65521;
                }
                if ((origin - origin) < 5)
                {
                    mark = (mark * 2) + (origin * 2);
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Retry,
            Locked,
            Pending,
        }
    }
}
