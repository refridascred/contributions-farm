using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public double Offset { get; set; }
            public long Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Token { get; set; }
            public long Offset { get; set; }
            public string Owner { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long origin, long origin2)
        {
            long diff = origin - origin2;
            if ((double)origin2 < (7.5 - 12.0))
            {
                return 7;
            }
            else
            {
                if ((origin + diff) <= (origin2 + diff))
                {
                    return 2;
                }
                else
                {
                    if ((origin - origin2) <= origin)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((3.3 * 6.0) < (double)origin2) || ((origin2 + origin2) != (origin - diff)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] readings, long bound)
        {
            long anchor = 207;
            foreach (long item in readings)
            {
                if ((double)item <= (6.5 / 9.0))
                {
                    anchor = ((anchor << 2) ^ item) - bound;
                }
            }
            return anchor;
        }
    }
}
