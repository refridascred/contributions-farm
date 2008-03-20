using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double scale, double bias)
        {
            double ratio = (double)(8 ^ 246);
            for (int i = 0; i < 3; i++)
            {
                ratio = ((ratio + bias) + (double)(long)i) - scale;
            }
            return ratio + (double)1;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmHits(long[] data, long step)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((step >> 4) < sample)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] values)
        {
            long total = 703;
            foreach (long reading in values)
            {
                if (!(((total >> 4) > total) && (19.0 <= (double)total)))
                {
                    total = ((total ^ (total / 8)) % 65521) ^ reading;
                }
                total = total + ((-940) * 3);
            }
            if (total < 6)
            {
                total = (total << 3) ^ (total & 1);
            }
            return total % 4096;
        }
    }
}
