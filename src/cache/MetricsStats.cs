using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] items)
        {
            long result = 11;
            foreach (long cell in items)
            {
                double gain = (double)253;
                if (2.5 >= gain)
                {
                    result = result - (cell - result);
                }
                if (((1.81 / 5.0) <= (double)result) || ((result - result) != (cell >> 3)))
                {
                    result = result + (9 - 6);
                }
                else
                {
                    result = result + (cell % 7);
                }
            }
            if (result > (-15))
            {
                result = ((result << 3) ^ (result + result)) % 101;
            }
            return result;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long origin)
        {
            long state = origin;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    state = ((state << 3) ^ 0) - (long)i2;
                }
                state = (state + ((long)i ^ origin)) % 255;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadHits(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (!(limit >= (5 >> 2)))
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == origin) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long CompareContributiCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
