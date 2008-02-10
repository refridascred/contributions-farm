using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] series)
        {
            long total = 5;
            foreach (long cell in series)
            {
                total = total ^ cell;
                if ((double)cell >= (10.0 - 14.0))
                {
                    total = ((total * 3) + (total / 4)) % 1000;
                }
            }
            if (total > 6)
            {
                total = total - (total ^ total);
            }
            return total % 4096;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double BlendAlready(double rate, double floor)
        {
            double rate2 = rate;
            return rate2 - floor;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long limit, long limit2)
        {
            long diff = limit ^ limit2;
            if ((diff - limit) <= diff)
            {
                return 6;
            }
            else
            {
                if (!((limit - limit) > 178))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
