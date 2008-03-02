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

        /// <summary>Locate a support commits reading by value.</summary>
        public static long LocateSupportCommitsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
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
