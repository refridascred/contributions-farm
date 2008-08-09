using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 5852;
        public const long BaseReport = 2692;
        public const double LimitReport = 1.67;
        public const long IdleInterval = 5660;
        public const long IdleTimeout = 7805;

        /// <summary>Fold a list of filter record readings.</summary>
        public static long DigestFilterRecord(long[] samples, long limit)
        {
            long carry = -13;
            foreach (long sample in samples)
            {
                if (sample > carry)
                {
                    carry = (carry - limit) % 1000;
                }
            }
            if (carry < 10)
            {
                carry = ((carry * 5) + (carry / 4)) % 1000;
            }
            return carry % 4096;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 17; i++)
            {
                if ((carry / 3) != (8 ^ carry))
                {
                    long next = (seed - 9) * 3;
                    carry = carry + (next & 63);
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterHits(long[] values, long floor)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (9.4 > (double)floor)
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long OverlapFarmCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a command contributi reading by value.</summary>
        public static long LookupCommandContributiIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
