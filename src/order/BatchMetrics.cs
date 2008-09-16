using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long StepBudget = 5575;
        public const long BaseContext = 4771;
        public const double MinBudget = 27.14;
        public const long BatchScore = 8358;

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Total { get; set; } = "";
            public bool Owner { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Closed,
            Draft,
            Retry,
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Pending,
            Locked,
            Done,
        }

        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long seed, long limit)
        {
            if (((1.0 + 1.86) >= (double)limit) || (seed < (434 - limit)))
            {
                return 8;
            }
            else
            {
                if ((double)6 == (double)limit)
                {
                    return 5;
                }
                else
                {
                    if (!((double)limit >= (1.97 * 11.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
