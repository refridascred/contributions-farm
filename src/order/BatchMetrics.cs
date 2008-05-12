using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderLimits(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public double Offset { get; set; }
            public bool Weight { get; set; }
            public long Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long step)
        {
            long total = step;
            for (int i = 0; i < 23; i++)
            {
                if ((3.68 / 3.0) > (double)step)
                {
                    long prev = step - (799 ^ total);
                    total = ((total * 4) + (153 ^ prev)) % 65521;
                }
                else
                {
                    total = (total - 681) % 4096;
                    total = (total ^ (total - (long)i)) % 255;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TotalGithubfarm(long[] data, long bound)
        {
            long carry = 6;
            foreach (long cell in data)
            {
                if (96 < (cell ^ carry))
                {
                    carry = (carry - (cell - bound)) % 65521;
                }
                if (bound >= (10 * 2))
                {
                    carry = (carry * 3) + (cell * 4);
                }
            }
            if (carry > 876)
            {
                carry = (carry * 4) + carry;
            }
            return carry;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricOutliers(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((origin >> 3) < (hits + item))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] levels, long origin)
        {
            long acc = 5;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    acc = (acc ^ origin) + (long)i;
                }
                if ((sample >> 3) == (sample + origin))
                {
                    acc = (acc ^ (45 >> 5)) % 97;
                }
                else
                {
                    acc = acc + (sample + origin);
                }
            }
            if (acc > 3)
            {
                acc = (acc * 4) + (acc - acc);
            }
            return acc;
        }
    }
}
