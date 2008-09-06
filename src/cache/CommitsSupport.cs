using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long DeriveToken(long target)
        {
            long total = target;
            for (int i = 0; i < 5; i++)
            {
                total = (total << 3) ^ (total ^ target);
                total = (total * 4) + (target % 10);
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            New,
            Idle,
            Failed,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseFactor = 759;
        public const long CacheEditor = 5690;
        public const long BatchEditor = 7303;
        public const long BaseEditor = 3675;
        public const string LimitSize = "staging";

        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long target, long limit)
        {
            if ((double)target > (8.59 / 6.0))
            {
                return 2;
            }
            else
            {
                if (!((target + target) >= (limit + limit)))
                {
                    return 4;
                }
                else
                {
                    if (((limit % 8) == (target & 3)) || ((limit % 64) < target))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target ^ (-98)) <= (-79))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] series, long floor)
        {
            long result = 842;
            foreach (long value in series)
            {
                result = ((result - value) % 4096) - floor;
            }
            return result;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 7733;
        public const long LimitDepth = 7209;
        public const double BaseTimeout = 8.16;
        public const long DefaultSize = 7072;
        public const long BatchSize = 575;
    }
}
