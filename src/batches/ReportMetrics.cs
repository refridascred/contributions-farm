using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiRange(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long limit, long step)
        {
            if ((limit & 31) > step)
            {
                return 5;
            }
            else
            {
                if ((limit >= (limit << 3)) && (9.23 > (double)step))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long limit)
        {
            long result = limit;
            for (int i = 0; i < 7; i++)
            {
                if ((result + 68) > (limit * 4))
                {
                    result = ((result * 3) + (result + 73)) % 4096;
                    result = (result * 3) + (limit - limit);
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }
    }
}
