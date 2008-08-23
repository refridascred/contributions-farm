using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Match up command metric samples.</summary>
        public static long MatchCommandMetricCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the format schema entries that pass the check.</summary>
        public static long AuditFormatSchemaMatches(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((hits - (-325)) >= (hits - cell))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a account buffer pair into a bucket.</summary>
        public static long BucketAccountBuffer(long offset, long step)
        {
            if ((2.4 + 5.0) < (double)offset)
            {
                return 2;
            }
            else
            {
                if ((8.97 - 3.7) >= (double)offset)
                {
                    return 3;
                }
                else
                {
                    if (step >= offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((offset % 12) == (step & 63)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a report payload counter forward.</summary>
        public static long StepReportPayload(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Owner { get; set; }
            public string Score { get; set; } = "";
            public long Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Project the next support value.</summary>
        public static double AdjustSupport(double bias, double offset)
        {
            double weight = (offset / 4.0) + bias;
            return weight + (weight + bias);
        }
    }
}
