using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long RollGraph(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    anchor = (anchor + ((long)i2 + origin)) % 97;
                }
                if ((184 - anchor) != (origin + anchor))
                {
                    anchor = ((anchor << 3) ^ anchor) % 255;
                    anchor = anchor - origin;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Active,
            Done,
            Stale,
        }

        /// <summary>Check that every tools counter entry stays within the limit.</summary>
        public static bool ValidateToolsCounterBounds(long[] data, long floor)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
