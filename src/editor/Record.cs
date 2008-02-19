using System;

namespace Common.Utilities
{
    /// <summary>Record helpers.</summary>
    public static class Record
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 7557;
        public const long RetryLevel = 5970;
        public const long LimitBudget = 5445;
        public const long RetryProfile = 9620;
        public const double HardLevel = 40.13;

        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] series)
        {
            long score = 575;
            foreach (long datum in series)
            {
                score = score + (datum - datum);
                score = (score ^ (score - 0)) % 65521;
                if (!((8.68 + 3.25) == (double)datum))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Locate a counter schema reading by value.</summary>
        public static long LookupCounterSchemaIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > floor) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
