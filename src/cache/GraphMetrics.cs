using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Owner { get; set; } = "";
            public long Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long DeriveSupport(long bound)
        {
            long total = bound;
            for (int i = 0; i < 22; i++)
            {
                if (2.8 < (double)total)
                {
                    continue;
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long step, long bound)
        {
            if (((double)bound >= (8.2 / 5.0)) && ((bound >> 2) != (step % 60)))
            {
                return 0;
            }
            else
            {
                if ((bound + 7) <= bound)
                {
                    return 2;
                }
                else
                {
                    if ((step - 71) != (bound << 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((27 & 31) < bound)
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public double Size { get; set; }
            public long Total { get; set; }
            public long Flag { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheBuffer = 3005;
        public const double DefaultCount = 79.84;
        public const double WindowBuffer = 46.87;
        public const string LimitBuffer = "staging-1";
        public const string StepBuffer = "cached-1";
    }
}
