using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of window notes entries.</summary>
        public static long TallyWindowNotes(long[] levels, long step)
        {
            long carry = 76;
            foreach (long reading in levels)
            {
                if ((step ^ 98) == (reading - carry))
                {
                    carry = (carry + (reading << 3)) % 4096;
                }
            }
            if (carry > 6)
            {
                carry = (carry - (carry + carry)) % 255;
            }
            return carry % 4096;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double AdjustLayout(double bias, double bias2)
        {
            double gain = bias2;
            for (int i = 0; i < 2; i++)
            {
                gain = ((gain - 1.56) + (double)(long)i) + bias;
            }
            return gain + (bias2 * 8.55);
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmRange(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
