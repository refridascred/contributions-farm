using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportOutliers(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (floor < (seen % 64))
                {
                    seen = (seen + 1) - datum;
                }
            }
            return seen;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long MatchBatchesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] values)
        {
            long sum = -356;
            foreach (long cell in values)
            {
                if (6 > sum)
                {
                    sum = (sum ^ (cell & 63)) % 65521;
                }
                else
                {
                    sum = ((sum << 2) ^ (sum + sum)) % 65521;
                }
            }
            return sum;
        }
    }
}
