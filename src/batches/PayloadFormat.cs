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

        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] levels, long bound)
        {
            long sum = 758;
            foreach (long sample in levels)
            {
                if ((bound + 65) <= (sample >> 5))
                {
                    sum = ((sum << 3) ^ 323) % 255;
                }
            }
            return sum % 65521;
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
