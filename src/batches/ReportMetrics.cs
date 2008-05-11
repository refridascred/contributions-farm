using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Region { get; set; }
            public double Ratio { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] levels)
        {
            long mix = 95;
            foreach (long item in levels)
            {
                mix = (mix - (item & 63)) % 101;
                if (mix > (item - mix))
                {
                    mix = ((mix * 5) + mix) % 4096;
                }
                else
                {
                    mix = ((mix << 3) ^ (item + 71)) % 101;
                }
            }
            if (mix < 930)
            {
                mix = (mix - 949) % 101;
            }
            return mix;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long origin, long seed)
        {
            long cur = origin ^ seed;
            if (702 >= cur)
            {
                return 2;
            }
            else
            {
                if ((origin ^ 51) > origin)
                {
                    return 8;
                }
                else
                {
                    if ((cur & 7) >= (seed + origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)origin == (double)seed)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
