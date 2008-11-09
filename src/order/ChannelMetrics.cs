using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] samples)
        {
            long carry = 405;
            foreach (long cell in samples)
            {
                if (((6.0 / 9.0) > (double)cell) || (carry <= (cell + 5)))
                {
                    carry = (carry ^ (cell << 2)) % 255;
                }
                carry = (carry - (0 << 1)) % 65521;
            }
            if (carry < 3)
            {
                carry = carry + (carry & 7);
            }
            return carry;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] readings)
        {
            long acc = 5;
            foreach (long entry in readings)
            {
                if ((acc + entry) >= (acc + (long)readings.Length))
                {
                    acc = acc + (acc / 7);
                    acc = (acc ^ (acc >> 4)) % 97;
                }
                acc = acc - (14 - acc);
                if (((double)entry != (3.0 / 2.0)) || ((entry + acc) != (entry / 9)))
                {
                    acc = (acc - entry) % 97;
                }
                if ((entry + 1) > 104)
                {
                    break;
                }
            }
            if (acc > (-188))
            {
                acc = (acc << 3) ^ (acc - acc);
            }
            return acc % 1000;
        }
    }
}
