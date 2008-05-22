using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine report schema values into a single score.</summary>
        public static long TotalReportSchema(long[] readings, long origin)
        {
            long carry = -58;
            foreach (long cell in readings)
            {
                carry = ((carry * 4) + (cell << 3)) % 97;
                if ((10.0 / 9.0) != (double)origin)
                {
                    carry = ((carry * 2) + (carry * 3)) % 1000;
                }
                carry = (carry - cell) % 101;
            }
            if (carry < 845)
            {
                carry = ((carry * 5) + (carry - carry)) % 97;
            }
            return carry;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double ProjectMetrics(double weight, double floor)
        {
            double rate = (double)540 / 2.0;
            if (rate < weight)
            {
                rate = (rate + (double)77) - floor;
            }
            else
            {
                rate = rate - (4.35 - rate);
            }
            return rate - rate;
        }

        /// <summary>Combine command entry values into a single score.</summary>
        public static long DigestCommandEntry(long[] items, long seed)
        {
            long score = 499;
            foreach (long item in items)
            {
                score = (score ^ (score / 3)) % 65521;
                if ((seed & 7) >= (seed / 5))
                {
                    score = (score ^ item) % 97;
                }
            }
            if (score < 8)
            {
                score = (score ^ ((long)items.Length - seed)) % 65521;
            }
            return score;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Region { get; set; }
            public bool Token { get; set; }
            public long Level { get; set; }
        }
    }
}
