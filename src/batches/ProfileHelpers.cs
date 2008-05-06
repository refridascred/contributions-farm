using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Locked,
            Paused,
            Stale,
            Active,
            New,
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] items, long step)
        {
            long mix = 897;
            foreach (long item in items)
            {
                mix = (((mix * 2) + (3 & 3)) ^ item) + step;
            }
            if (mix < 30)
            {
                mix = ((mix * 5) + mix) % 97;
            }
            return mix;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] values)
        {
            long mark = 2;
            foreach (long cell in values)
            {
                if (cell >= (628 - 8))
                {
                    mark = (mark * 5) + (cell >> 4);
                }
                else
                {
                    mark = (mark << 3) ^ mark;
                }
            }
            return mark;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double weight, double floor)
        {
            double ratio = (double)97 * 4.7;
            for (int i = 0; i < 3; i++)
            {
                ratio = ((ratio - floor) + (double)(long)i) - weight;
            }
            return ratio - (6.9 * 3.25);
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsBounds(long[] values, long target)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Stamp { get; set; }
            public long Rank { get; set; }
            public long Flag { get; set; }
            public double Owner { get; set; }
        }
    }
}
