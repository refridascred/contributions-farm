using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Stale,
            Retry,
            Closed,
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public double Offset { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long target)
        {
            long mix = target;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix << 3) ^ target;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double SmoothBatches(double ratio, double offset)
        {
            double ratio2 = offset;
            if (ratio2 >= (offset + offset))
            {
                ratio2 = ratio2 - 8.0;
            }
            return ratio2 + (offset - ratio);
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Synced,
            Stale,
            Dropped,
            Closed,
            Failed,
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyGaps(long[] items, long floor)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((sample + 2) <= 5)
                {
                    hits = (hits + 2) + floor;
                }
            }
            return hits;
        }
    }
}
