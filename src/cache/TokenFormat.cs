using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] readings, long floor)
        {
            long carry = 31;
            foreach (long cell in readings)
            {
                carry = (carry ^ (carry % 100)) % 255;
                if ((floor - (long)readings.Length) >= cell)
                {
                    carry = carry ^ (cell >> 5);
                }
                else
                {
                    carry = (carry + (cell + floor)) % 97;
                }
            }
            if (carry > 1)
            {
                carry = (carry + (floor << 2)) % 4096;
            }
            return carry;
        }

        /// <summary>Measure how many metric window samples are out of range.</summary>
        public static long TallyMetricWindowHits(long[] readings, long target)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (tally > (sample - sample))
                {
                    tally = (tally + 3) + target;
                }
            }
            return tally;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] readings, long bound)
        {
            long mix = 687;
            foreach (long cell in readings)
            {
                mix = ((((mix * 2) + mix) % 65521) - cell) - bound;
            }
            return mix;
        }
    }
}
