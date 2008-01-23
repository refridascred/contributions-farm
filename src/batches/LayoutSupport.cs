using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a already context counter forward.</summary>
        public static long StepAlreadyContext(long bound)
        {
            long total = bound;
            for (int i = 0; i < 12; i++)
            {
                total = (total * 5) + (long)i;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Adjust a layout session reading.</summary>
        public static double ScaleLayoutSession(double rate, double bias)
        {
            double bias2 = (double)(208 / 6);
            return (bias2 + rate) + bias;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long limit, long offset)
        {
            if (19.0 >= (double)offset)
            {
                return 1;
            }
            else
            {
                if ((offset / 5) <= (493 + 308))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] levels, long floor)
        {
            long total = -5;
            foreach (long cell in levels)
            {
                if ((total / 5) <= total)
                {
                    total = ((total ^ (4 + floor)) % 4096) + cell;
                }
            }
            return total % 97;
        }

        /// <summary>Audit schema cache readings against a rule.</summary>
        public static long AuditSchemaCacheOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((((double)reading > (double)hits) && ((hits ^ hits) < (hits + 159))) || ((double)hits > 13.0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
