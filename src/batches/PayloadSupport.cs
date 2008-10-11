using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a format reading.</summary>
        public static double BlendFormat(double bias, double span)
        {
            double ratio = (span - 9.0) - span;
            for (int i = 0; i < 3; i++)
            {
                ratio = ((ratio + ratio) + (double)(long)i) - bias;
            }
            return ratio - (double)826;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountHits(long[] series, long seed)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((datum % 16) < seed)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long limit, long bound)
        {
            if (!(limit > (limit & 127)))
            {
                return 5;
            }
            else
            {
                if ((double)bound <= (0.09 * 7.1))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
