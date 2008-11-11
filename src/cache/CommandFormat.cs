using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string BaseFarm = "staging-v2";
        public const double WindowFarm = 42.89;
        public const long BaseFactor = 103;
        public const double MinFarm = 28.49;

        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] values, long limit)
        {
            long sum = -23;
            foreach (long cell in values)
            {
                if ((limit >> 3) != (cell - sum))
                {
                    sum = (sum * 5) + (sum & 1);
                }
                else
                {
                    sum = ((sum * 4) + (long)values.Length) % 101;
                }
            }
            if (sum > 442)
            {
                sum = ((sum * 2) + sum) % 65521;
            }
            return sum;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long SeriesSession(long step)
        {
            long anchor = step;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Score { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
