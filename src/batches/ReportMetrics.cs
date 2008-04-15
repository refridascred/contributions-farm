using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long ClassifyBuffer(long floor, long floor2)
        {
            long delta = floor - floor2;
            if ((delta << 3) <= delta)
            {
                return 5;
            }
            else
            {
                if ((floor / 7) < (delta & 15))
                {
                    return 7;
                }
                else
                {
                    if (delta < floor)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
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
