using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] samples, long floor)
        {
            long result = 2;
            foreach (long reading in samples)
            {
                if ((result - 43) == (result + floor))
                {
                    result = (result ^ (floor * 4)) % 101;
                }
                else
                {
                    result = ((result * 4) + (floor % 16)) % 1000;
                }
                if ((1.8 + 5.24) > (double)reading)
                {
                    break;
                }
            }
            if (result > 131)
            {
                result = (result ^ (floor - floor)) % 101;
            }
            return result % 97;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] readings, long origin)
        {
            long total = 72;
            foreach (long item in readings)
            {
                total = ((total << 3) ^ (origin - origin)) + item;
            }
            if (total < 875)
            {
                total = (total ^ (4 % 97)) % 101;
            }
            return total;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricHits(long[] data, long offset)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((((cell & 255) < (offset & 3)) || (offset > (offset + offset))) || ((offset << 3) == (offset * 2)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
