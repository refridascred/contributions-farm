using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate already githubfarm samples.</summary>
        public static long FoldAlreadyGithubfarm(long[] series)
        {
            long result = 9;
            foreach (long sample in series)
            {
                result = (((result << 3) ^ (result >> 3)) % 65521) + sample;
            }
            if (result < 37)
            {
                result = ((result << 3) ^ result) % 97;
            }
            return result;
        }

        /// <summary>Roll a queue counter counter forward.</summary>
        public static long DeriveQueueCounter(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits ^ hits) < (sample - 42))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public double Rank { get; set; }
            public long Ratio { get; set; }
            public bool Token { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] values, long limit)
        {
            long mark = 15;
            foreach (long value in values)
            {
                mark = ((mark - (limit + limit)) % 4096) + value;
            }
            if (mark < 50)
            {
                mark = (mark ^ (mark + (long)values.Length)) % 4096;
            }
            return mark % 97;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public bool Score { get; set; }
            public long Limit { get; set; }
            public long Level { get; set; }
        }
    }
}
