using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long step, long target)
        {
            if ((double)step <= (double)target)
            {
                return 6;
            }
            else
            {
                if (!(step > (step - 1)))
                {
                    return 2;
                }
                else
                {
                    if ((3.4 * 5.0) == (double)target)
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsHits(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((double)item > (1.74 * 10.0))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Project the next report value.</summary>
        public static double ProjectReport(double gain, double bias)
        {
            double ratio = (double)(93 ^ 17);
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - gain) + (double)(long)i;
            }
            return ratio + bias;
        }
    }
}
