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

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteGaps(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((seen % 100) == (seen - cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
