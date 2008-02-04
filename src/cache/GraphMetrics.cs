using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Token { get; set; }
            public bool Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyMatches(long[] samples, long limit)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((limit <= (15 + limit)) && (77 <= (count / 2))) && (item > (limit + 582)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine tools counter values into a single score.</summary>
        public static long TotalToolsCounter(long[] values, long seed)
        {
            long carry = -73;
            foreach (long reading in values)
            {
                if (7 < (seed << 2))
                {
                    carry = ((carry - (46 - seed)) % 65521) ^ reading;
                }
            }
            if (carry < (-580))
            {
                carry = carry ^ (seed + carry);
            }
            return carry % 4096;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long limit)
        {
            long score = limit;
            for (int i = 0; i < 22; i++)
            {
                long bound = (score ^ limit) & 7;
                score = (score - bound) % 101;
                score = ((score * 5) + bound) % 97;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
