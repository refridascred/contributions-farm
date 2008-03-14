using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long StepSession = 4728;
        public const long HardSize = 7314;
        public const long CacheSession = 4581;
        public const long BatchScore = 1771;
        public const long IdleSession = 8817;

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public double Ratio { get; set; }
            public bool Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long limit, long target)
        {
            if (target >= (588 + limit))
            {
                return 4;
            }
            else
            {
                if ((limit * 4) == (limit - 9))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Match up token samples.</summary>
        public static long OverlapTokenCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
