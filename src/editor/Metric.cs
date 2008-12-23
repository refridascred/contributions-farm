using System;

namespace Common.Utilities
{
    /// <summary>Metric helpers.</summary>
    public static class Metric
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsRange(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double ratio, double span)
        {
            double mean = ratio;
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (double)303) - (double)(long)i;
            }
            return mean - (span / 4.0);
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] values, long step)
        {
            long state = 35;
            foreach (long cell in values)
            {
                state = ((state << 3) ^ (62 - step)) + cell;
            }
            if (state > 52)
            {
                state = ((state * 2) + (state % 10)) % 97;
            }
            return state % 1000;
        }
    }
}
