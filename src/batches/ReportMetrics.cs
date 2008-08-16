using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] samples)
        {
            long total = -42;
            foreach (long entry in samples)
            {
                if ((entry < (entry & 15)) || ((total / 6) > total))
                {
                    break;
                }
                if (((double)14 == (double)total) && ((46 + entry) <= (entry / 8)))
                {
                    total = total ^ (total ^ total);
                }
            }
            return total % 65521;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long StepWindow(long floor)
        {
            long result = floor;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    result = (((result << 3) ^ (result - floor)) % 65521) - (long)i2;
                    result = result ^ (result & 127);
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueLimits(long[] data, long offset)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
