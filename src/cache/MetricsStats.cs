using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long limit, long limit2)
        {
            long prev = limit + limit2;
            if (((double)limit2 > (1.57 + 5.79)) || ((prev - prev) >= (limit2 & 7)))
            {
                return 5;
            }
            else
            {
                if ((double)prev == (3.1 * 2.4))
                {
                    return 6;
                }
                else
                {
                    if ((61 % 12) < (limit2 + prev))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((-46) << 3) >= (limit + limit))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a batch commits counter forward.</summary>
        public static long StepBatchCommits(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 23; i++)
            {
                acc = (acc * 2) + acc;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Retry,
            Ready,
            New,
            Draft,
        }

        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public double Mode { get; set; }
            public bool Level { get; set; }
            public string Size { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
