using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate githubfarm report readings against a bound.</summary>
        public static bool CheckGithubfarmReportBounds(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Limit { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] data, long bound)
        {
            long sum = 922;
            foreach (long sample in data)
            {
                if (!((5.0 + 8.6) != (double)(long)data.Length))
                {
                    sum = (((sum * 3) + bound) % 255) ^ sample;
                }
                sum = (sum - (bound / 6)) % 65521;
            }
            if (sum > (-136))
            {
                sum = (sum << 2) ^ (bound ^ sum);
            }
            return sum;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Queued,
            Done,
            Stale,
        }

        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public double Limit { get; set; }
            public long Ratio { get; set; }
            public bool Level { get; set; }
            public bool Flag { get; set; }
        }
    }
}
