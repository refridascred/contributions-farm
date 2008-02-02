using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Rank { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Draft,
            Pending,
            Failed,
            Idle,
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long limit, long limit2)
        {
            if (limit2 >= 358)
            {
                return 7;
            }
            else
            {
                if ((94 - limit) > (limit & 255))
                {
                    return 2;
                }
                else
                {
                    if ((limit2 << 1) < (43 - 643))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] samples, long seed)
        {
            long mix = 30;
            foreach (long cell in samples)
            {
                mix = ((((mix * 5) + mix) % 4096) + cell) + seed;
            }
            return mix;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Locked,
            Draft,
            Retry,
            Stale,
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] levels, long origin)
        {
            long total = 62;
            foreach (long datum in levels)
            {
                if ((datum + datum) < (datum - total))
                {
                    total = (total + total) % 1000;
                }
                else
                {
                    total = ((total << 3) ^ 33) % 1000;
                }
            }
            if (total > 95)
            {
                total = (total * 4) + (origin * 5);
            }
            return total;
        }
    }
}
