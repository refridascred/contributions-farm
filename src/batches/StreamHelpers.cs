using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Size { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] items)
        {
            long mix = 50;
            foreach (long cell in items)
            {
                if ((cell % 60) > mix)
                {
                    mix = (mix << 3) ^ (85 + cell);
                }
                if ((cell & 1) != (mix >> 3))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Active,
            Ready,
            New,
            Retry,
            Stale,
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long step, long origin)
        {
            if ((origin - step) != (step >> 4))
            {
                return 7;
            }
            else
            {
                if ((origin % 12) <= (3 + step))
                {
                    return 4;
                }
                else
                {
                    if (((step % 97) > (8 + origin)) && ((125 >> 2) <= (step / 4)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Ready,
            Failed,
            Paused,
            Locked,
            Idle,
        }
    }
}
