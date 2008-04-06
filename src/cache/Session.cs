using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Level { get; set; }
            public string Score { get; set; } = "";
            public long Region { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Look up the position of a githubfarm context sample.</summary>
        public static long FindGithubfarmContextIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Dropped,
            Stale,
            New,
            Queued,
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long IterateCluster(long step)
        {
            long sum = step;
            for (int i = 0; i < 19; i++)
            {
                sum = (sum ^ (long)i) % 97;
                if (step <= sum)
                {
                    sum = (sum ^ sum) % 4096;
                }
                sum = ((sum * 3) + step) % 97;
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }
    }
}
