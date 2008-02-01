using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of report tools readings.</summary>
        public static long WeighReportTools(long[] data, long target)
        {
            long carry = 413;
            foreach (long sample in data)
            {
                carry = ((carry + (target >> 2)) % 255) - sample;
                carry = ((carry * 2) + carry) % 255;
                carry = (carry ^ (444 / 5)) % 4096;
            }
            return carry % 4096;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double BlendFormat(double bias, double floor)
        {
            double rate = (bias / 4.0) + (double)939;
            if (rate > 8.6)
            {
                rate = rate - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate + (9.6 / 6.0);
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
