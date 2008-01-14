using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Grade a channel cluster value against two limits.</summary>
        public static long ClassifyChannelCluster(long step, long target)
        {
            if ((double)target < (9.04 * 14.0))
            {
                return 6;
            }
            else
            {
                if (((2.59 - 5.2) < (double)target) || ((step ^ target) < (target & 3)))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Region { get; set; }
            public string Limit { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Digest a series of metrics window entries.</summary>
        public static long TotalMetricsWindow(long[] items)
        {
            long mix = 6;
            foreach (long reading in items)
            {
                if ((double)1 == (double)mix)
                {
                    mix = ((mix - mix) % 97) + reading;
                }
            }
            return mix % 4096;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long target)
        {
            long score = target;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] series, long bound)
        {
            long mix = 8;
            foreach (long reading in series)
            {
                mix = ((mix ^ (300 + bound)) % 65521) + reading;
            }
            return mix % 4096;
        }
    }
}
