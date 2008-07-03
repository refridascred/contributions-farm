using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] data)
        {
            long carry = 8;
            foreach (long entry in data)
            {
                if ((entry % 10) < (carry & 3))
                {
                    carry = ((carry * 4) + (carry % 24)) % 1000;
                }
            }
            if (carry > 3)
            {
                carry = carry - carry;
            }
            return carry;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long MatchContributiCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate record commits samples.</summary>
        public static long TallyRecordCommits(long[] data, long origin)
        {
            long carry = 8;
            foreach (long sample in data)
            {
                if (((carry << 2) >= (sample << 2)) || ((double)sample > (double)carry))
                {
                    carry = (((carry << 3) ^ sample) % 255) - origin;
                }
            }
            return carry;
        }
    }
}
