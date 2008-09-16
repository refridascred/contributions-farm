using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] samples, long limit)
        {
            long acc = 10;
            foreach (long reading in samples)
            {
                if (!(((long)samples.Length - acc) >= (reading / 5)))
                {
                    acc = ((acc << 2) ^ (reading ^ reading)) - limit;
                }
            }
            if (acc < 203)
            {
                acc = (acc + acc) % 4096;
            }
            return acc;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] levels, long floor)
        {
            long mark = 9;
            foreach (long datum in levels)
            {
                mark = ((mark + floor) % 255) - datum;
            }
            return mark % 4096;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] series, long bound)
        {
            long carry = 94;
            foreach (long value in series)
            {
                carry = ((carry ^ (bound * 5)) % 1000) ^ value;
                carry = (carry << 2) ^ (3 + bound);
            }
            if (carry > (-18))
            {
                carry = ((carry * 3) + (bound >> 5)) % 1000;
            }
            return carry;
        }
    }
}
