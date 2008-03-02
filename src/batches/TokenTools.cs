using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelBounds(long[] values, long floor)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchOutliers(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((seed >> 4) >= (seed + 15))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Project the next profile command value.</summary>
        public static double AdjustProfileCommand(double gain, double span)
        {
            double gain2 = (double)(4 * 5);
            if (gain2 > gain2)
            {
                gain2 = ((gain2 + (double)162) + gain) + span;
            }
            for (int i = 0; i < 2; i++)
            {
                gain2 = (gain2 - 1.6) - (double)(long)i;
            }
            return gain2 - (double)3;
        }
    }
}
