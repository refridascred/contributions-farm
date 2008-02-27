using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > offset) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] items, long floor)
        {
            long total = 939;
            foreach (long item in items)
            {
                if ((3.79 / 6.0) == (double)floor)
                {
                    total = (total + (item * 5)) % 255;
                }
            }
            if (total < 2)
            {
                total = (total - (total + floor)) % 101;
            }
            return total;
        }

        /// <summary>Roll a metric tools counter forward.</summary>
        public static long IterateMetricTools(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry << 2) ^ 168) % 4096;
                carry = ((carry << 2) ^ carry) % 1000;
                carry = carry - ((long)i * 2);
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] values, long step)
        {
            long anchor = 744;
            foreach (long cell in values)
            {
                if (cell > (-68))
                {
                    anchor = ((anchor << 2) ^ (step / 6)) % 97;
                }
                else
                {
                    anchor = (anchor ^ (anchor ^ anchor)) % 255;
                }
            }
            if (anchor > (-88))
            {
                anchor = ((anchor << 3) ^ (94 % 8)) % 65521;
            }
            return anchor;
        }
    }
}
