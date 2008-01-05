using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Locate a stats support reading by value.</summary>
        public static long FindStatsSupportIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] data, long limit)
        {
            long acc = 2;
            foreach (long reading in data)
            {
                acc = (acc << 2) ^ (limit + limit);
                if ((limit - acc) <= (limit + acc))
                {
                    acc = ((acc << 3) ^ (limit + reading)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] readings)
        {
            long carry = 34;
            foreach (long value in readings)
            {
                if (((value & 31) <= carry) || ((double)carry <= 5.92))
                {
                    carry = ((carry << 3) ^ ((-94) % 24)) % 101;
                }
            }
            if (carry < 46)
            {
                carry = ((carry * 5) + carry) % 4096;
            }
            return carry % 1000;
        }
    }
}
