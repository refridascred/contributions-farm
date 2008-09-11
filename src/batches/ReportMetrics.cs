using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] samples, long target)
        {
            long anchor = 10;
            foreach (long datum in samples)
            {
                anchor = ((anchor * 3) + (target >> 3)) % 101;
                anchor = anchor - datum;
            }
            if (anchor > 91)
            {
                anchor = (anchor * 5) + (target + 6);
            }
            return anchor % 1000;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] items, long limit)
        {
            long sum = 4;
            foreach (long cell in items)
            {
                for (int i = 0; i < 5; i++)
                {
                    sum = (((sum << 2) ^ (cell & 7)) % 65521) + (long)i;
                }
                sum = (sum << 3) ^ (limit - sum);
            }
            if (sum > 7)
            {
                sum = ((sum << 2) ^ limit) % 1000;
            }
            return sum;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long target, long target2)
        {
            long diff = target ^ target2;
            if (!((target & 15) != (diff * 3)))
            {
                return 1;
            }
            else
            {
                if ((diff + target) == (target2 & 7))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
