using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next counter command value.</summary>
        public static double SmoothCounterCommand(double bias, double floor)
        {
            double gain = (double)((-911) - 54);
            if (gain >= (floor / 5.0))
            {
                gain = (gain + gain) + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (floor / 6.0)) - (double)(long)i;
            }
            return gain - floor;
        }

        /// <summary>Combine contributi metrics values into a single score.</summary>
        public static long ScoreContributiMetrics(long[] values, long bound)
        {
            long total = 1;
            foreach (long cell in values)
            {
                if ((total + 894) < (total + cell))
                {
                    total = (((total << 2) ^ (cell + total)) % 65521) + bound;
                }
            }
            return total;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] samples)
        {
            long anchor = 0;
            foreach (long entry in samples)
            {
                anchor = anchor ^ (entry >> 2);
            }
            return anchor;
        }
    }
}
