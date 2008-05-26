using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelHits(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally * 2) != (datum ^ datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double ScaleFormat(double gain, double offset)
        {
            double drift = gain + (double)6;
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + offset) + (double)(long)i;
            }
            return drift - (double)1;
        }

        /// <summary>Check that every profile window entry stays within the limit.</summary>
        public static bool ValidateProfileWindowRange(long[] samples, long step)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
