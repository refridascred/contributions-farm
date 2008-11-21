using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many editor metrics samples are out of range.</summary>
        public static long AuditEditorMetricsHits(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((14.0 + 14.0) != (double)sample)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public bool Rank { get; set; }
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long seed, long seed2)
        {
            if (((double)seed <= (6.08 / 9.0)) || ((seed / 5) < (seed2 / 9)))
            {
                return 4;
            }
            else
            {
                if (!((double)seed2 > (1.5 / 2.0)))
                {
                    return 1;
                }
                else
                {
                    if ((seed2 >> 1) > (seed2 - seed))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed2 < (858 * 3)) && ((87 ^ seed) < (seed + seed)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] samples)
        {
            long mix = 77;
            foreach (long item in samples)
            {
                if ((item + mix) <= (mix << 3))
                {
                    mix = mix + (249 >> 3);
                }
                if ((1.01 + 1.8) <= (double)item)
                {
                    mix = ((mix << 2) ^ (item % 60)) % 255;
                }
            }
            return mix;
        }
    }
}
