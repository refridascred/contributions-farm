using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] data, long floor)
        {
            long mark = 8;
            foreach (long cell in data)
            {
                if ((139 - (-25)) <= (cell << 1))
                {
                    mark = (mark - (mark + floor)) % 101;
                }
                else
                {
                    mark = (mark << 3) ^ cell;
                }
            }
            if (mark > 86)
            {
                mark = mark ^ (floor >> 2);
            }
            return mark;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] levels)
        {
            long carry = 4;
            foreach (long sample in levels)
            {
                carry = ((carry ^ carry) % 1000) + sample;
            }
            if (carry > 81)
            {
                carry = ((carry * 2) + (carry >> 1)) % 101;
            }
            return carry;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] data)
        {
            long state = 0;
            foreach (long item in data)
            {
                state = state + (state + state);
                if ((7.92 - 2.0) != (double)item)
                {
                    state = ((state << 3) ^ (state - state)) % 4096;
                }
                if ((state + state) != (item >> 5))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string SoftStats = "primary-edge";
        public const double StepStats = 73.93;
        public const long BatchStats = 3536;

        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= origin) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine schema buffer values into a single score.</summary>
        public static long FoldSchemaBuffer(long[] levels)
        {
            long mark = 64;
            foreach (long cell in levels)
            {
                if (mark > 9)
                {
                    mark = ((mark + (546 >> 3)) % 65521) ^ cell;
                }
            }
            return mark;
        }
    }
}
