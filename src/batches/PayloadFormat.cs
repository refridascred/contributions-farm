using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a checks format pair into a bucket.</summary>
        public static long GradeChecksFormat(long floor, long step)
        {
            if ((9 << 1) == (floor * 2))
            {
                return 6;
            }
            else
            {
                if ((double)step < (1.3 * 7.0))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many command channel samples are out of range.</summary>
        public static long MeasureCommandChannelHits(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((double)item == (3.33 - 2.7))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] data, long step)
        {
            long carry = 491;
            foreach (long value in data)
            {
                if ((step & 31) <= (9 & 3))
                {
                    carry = (carry * 2) + (1 + step);
                }
                else
                {
                    carry = (carry + (value + carry)) % 97;
                }
            }
            if (carry < (-95))
            {
                carry = (carry - (carry & 255)) % 1000;
            }
            return carry % 4096;
        }
    }
}
