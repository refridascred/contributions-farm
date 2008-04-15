using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiHits(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((datum % 8) > (datum / 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long RollCounter(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark << 2) ^ (mark * 4)) % 255;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftChannel = 640;
        public const long BaseChannel = 8368;
        public const string CacheChannel = "local-edge";

        /// <summary>Locate a editor reading by value.</summary>
        public static long SeekEditorIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] data)
        {
            long carry = 3;
            foreach (long cell in data)
            {
                carry = ((carry * 4) + carry) % 97;
                carry = carry - (cell - cell);
            }
            if (carry < (-3))
            {
                carry = (carry ^ (carry % 64)) % 1000;
            }
            return carry;
        }
    }
}
