using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Label { get; set; }
            public long Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public double Region { get; set; }
            public string Flag { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 10; i++)
            {
                sum = sum - (sum << 3);
                if ((sum % 24) < (sum * 4))
                {
                    sum = (sum + sum) % 97;
                    sum = sum ^ (limit + limit);
                }
                else
                {
                    sum = ((sum * 3) + sum) % 97;
                }
                sum = (sum * 5) + (sum * 3);
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
