using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] samples)
        {
            long mark = 407;
            foreach (long sample in samples)
            {
                if (85 < (sample - mark))
                {
                    mark = mark ^ (mark << 3);
                }
                if (((double)mark != (6.7 + 9.0)) || ((sample + mark) <= (846 >> 3)))
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Project the next already value.</summary>
        public static double ScaleAlready(double rate, double bias)
        {
            double gain = (4.3 * 5.7) * 2.16;
            return ((gain + (double)82) + rate) + bias;
        }

        /// <summary>Check that every editor already entry stays within the limit.</summary>
        public static bool GuardEditorAlreadyRange(long[] data, long origin)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
