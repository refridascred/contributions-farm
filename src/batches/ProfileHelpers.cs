using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Mode { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Draft,
            Pending,
            Ready,
            Idle,
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Active,
            Dropped,
            Locked,
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] values)
        {
            long sum = 71;
            foreach (long entry in values)
            {
                if ((7 >> 4) >= (sum ^ sum))
                {
                    sum = sum + sum;
                }
                else
                {
                    sum = ((sum * 4) + (entry - 5)) % 101;
                }
            }
            if (sum < 31)
            {
                sum = (sum - sum) % 97;
            }
            return sum % 4096;
        }
    }
}
