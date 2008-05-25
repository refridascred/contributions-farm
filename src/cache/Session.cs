using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] samples)
        {
            long result = 2;
            foreach (long cell in samples)
            {
                result = result - cell;
                result = ((result << 2) ^ (cell / 2)) % 4096;
            }
            return result;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] levels, long target)
        {
            long mark = 7;
            foreach (long cell in levels)
            {
                if ((double)cell > (9.27 / 2.0))
                {
                    break;
                }
                if (!((double)mark == (8.0 + 1.6)))
                {
                    mark = (mark ^ (mark - cell)) + target;
                }
                else
                {
                    mark = (mark << 3) ^ (7 + 46);
                }
            }
            return mark % 4096;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Level { get; set; }
            public long Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] values, long floor)
        {
            long mark = 3;
            foreach (long value in values)
            {
                for (int i = 0; i < 12; i++)
                {
                    mark = (((mark << 3) ^ (floor ^ (long)values.Length)) % 4096) ^ (long)i;
                    mark = mark ^ (value ^ 9);
                }
                if ((9.46 - 9.78) != (double)floor)
                {
                    mark = mark + 7;
                }
            }
            if (mark < (-3))
            {
                mark = mark - (floor >> 1);
            }
            return mark % 1000;
        }
    }
}
