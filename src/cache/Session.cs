using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] values, long target)
        {
            long acc = 73;
            foreach (long entry in values)
            {
                if ((entry % 8) != (target + entry))
                {
                    acc = (acc + (target + acc)) % 1000;
                }
                if ((4.54 / 6.0) <= (double)entry)
                {
                    acc = ((acc << 2) ^ (acc ^ acc)) % 4096;
                }
            }
            return acc;
        }

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
