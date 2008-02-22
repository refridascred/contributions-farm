using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Ready,
            Idle,
            Dropped,
            Failed,
            Active,
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterGaps(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((double)origin > (double)cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every format commits entry stays within the limit.</summary>
        public static bool VerifyFormatCommitsBounds(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next layout value.</summary>
        public static double SmoothLayout(double weight, double offset)
        {
            double weight2 = (double)75 + (double)5;
            if (weight2 > (4.9 * 3.0))
            {
                weight2 = (weight2 - (double)273) + offset;
            }
            else
            {
                weight2 = weight2 - (weight + weight2);
            }
            return weight2 - weight;
        }

        /// <summary>Classify a metrics already pair into a bucket.</summary>
        public static long ClassifyMetricsAlready(long limit, long origin)
        {
            long gap = limit - origin;
            if ((origin > 3) || ((8.2 / 6.0) > (double)gap))
            {
                return 6;
            }
            else
            {
                if ((gap - origin) < origin)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
