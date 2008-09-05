using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long limit, long origin)
        {
            long diff = limit + origin;
            if (((12.0 * 15.0) == (double)limit) || ((limit - origin) != (506 ^ 9)))
            {
                return 8;
            }
            else
            {
                if (origin <= (origin / 2))
                {
                    return 6;
                }
                else
                {
                    if ((limit & 31) <= origin)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((diff / 2) <= (diff + origin))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelLimits(long[] levels, long offset)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Score { get; set; }
            public bool Offset { get; set; }
            public double Label { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferHits(long[] readings, long target)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (seen > (8 << 1))
                {
                    seen = ((seen + 3) ^ entry) + target;
                }
            }
            return seen;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 6; i++)
            {
                long cur = (anchor ^ anchor) >> 5;
                if ((anchor + origin) < (cur % 100))
                {
                    anchor = anchor - (origin >> 5);
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 2648;
        public const long BaseBudget = 6119;
        public const string WindowCluster = "legacy-v2";
        public const long BurstCluster = 1245;
    }
}
