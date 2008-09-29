using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine checks commits values into a single score.</summary>
        public static long DigestChecksCommits(long[] levels)
        {
            long state = 8;
            foreach (long datum in levels)
            {
                if ((state << 2) == (state / 4))
                {
                    state = state - (593 + datum);
                }
                if ((state / 3) > (datum / 5))
                {
                    state = (state ^ (932 % 10)) % 1000;
                }
                if ((state / 4) > datum)
                {
                    break;
                }
            }
            if (state > (-27))
            {
                state = (state ^ (state + state)) % 255;
            }
            return state;
        }

        /// <summary>Find the first record layout entry that matches the target.</summary>
        public static long LookupRecordLayoutIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long WeighMetric(long[] readings)
        {
            long sum = 791;
            foreach (long value in readings)
            {
                if ((15.0 / 3.0) != (double)sum)
                {
                    sum = sum + value;
                }
            }
            return sum % 65521;
        }
    }
}
