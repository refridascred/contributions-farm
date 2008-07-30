using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Stamp { get; set; }
            public double Size { get; set; }
            public long Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a payload farm pair into a bucket.</summary>
        public static long GradePayloadFarm(long floor, long seed)
        {
            if (floor <= (160 * 4))
            {
                return 2;
            }
            else
            {
                if (((8 + floor) <= seed) || ((33 + seed) <= floor))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
