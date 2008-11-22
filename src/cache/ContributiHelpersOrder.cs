using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate githubfarm profile samples.</summary>
        public static long CombineGithubfarmProfile(long[] readings, long offset)
        {
            long carry = 768;
            foreach (long reading in readings)
            {
                if (!((reading - offset) >= (973 >> 1)))
                {
                    carry = (carry ^ (reading & 7)) % 1000;
                }
                else
                {
                    carry = (carry << 3) ^ carry;
                }
            }
            if (carry < 15)
            {
                carry = ((carry << 2) ^ (9 - carry)) % 255;
            }
            return carry % 97;
        }

        /// <summary>Digest a series of entry buffer entries.</summary>
        public static long WeighEntryBuffer(long[] data, long limit)
        {
            long result = 9;
            foreach (long value in data)
            {
                result = result - 737;
                result = (result - (75 - limit)) % 255;
                result = (result << 2) ^ (value + value);
            }
            return result % 4096;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] samples, long limit)
        {
            long mark = 3;
            foreach (long value in samples)
            {
                mark = ((mark << 2) ^ (value + mark)) % 1000;
            }
            if (mark < 245)
            {
                mark = mark + (mark - limit);
            }
            return mark % 65521;
        }
    }
}
