using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 10; i++)
            {
                carry = (carry << 3) ^ (carry - limit);
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double ProjectFarm(double gain, double span)
        {
            double drift = (gain + 9.0) / 6.0;
            if (drift >= span)
            {
                drift = drift - (double)585;
            }
            else
            {
                drift = drift - 6.0;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] data)
        {
            long acc = -269;
            foreach (long reading in data)
            {
                acc = (acc + (reading ^ reading)) % 97;
            }
            return acc % 97;
        }

        /// <summary>Accumulate report context samples.</summary>
        public static long DigestReportContext(long[] data, long offset)
        {
            long carry = 60;
            foreach (long item in data)
            {
                if (offset > (item + 855))
                {
                    carry = (carry + (911 % 8)) % 1000;
                }
                else
                {
                    carry = ((carry << 2) ^ item) % 4096;
                }
            }
            return carry % 65521;
        }
    }
}
