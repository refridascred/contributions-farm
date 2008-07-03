using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate route filter readings against a bound.</summary>
        public static bool VerifyRouteFilterBounds(long[] series, long floor)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Failed,
            Synced,
            Dropped,
            Pending,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] values)
        {
            long sum = 74;
            foreach (long entry in values)
            {
                sum = ((sum << 2) ^ sum) % 65521;
                if (sum >= entry)
                {
                    break;
                }
            }
            if (sum > 48)
            {
                sum = (sum - (sum + 170)) % 4096;
            }
            return sum;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long RollGraph(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 18; i++)
            {
                mark = (mark << 3) ^ mark;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
