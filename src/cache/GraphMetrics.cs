using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Idle,
            Closed,
            Draft,
            Paused,
            Active,
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] data)
        {
            long anchor = -7;
            foreach (long cell in data)
            {
                anchor = (anchor + anchor) % 97;
                anchor = ((anchor * 2) + cell) % 1000;
                anchor = (anchor << 3) ^ (anchor >> 5);
                if ((anchor < (cell + cell)) && (cell < (anchor & 63)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long RollFarm(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Locked,
            Done,
            Ready,
            Dropped,
            Stale,
        }

        /// <summary>Check that every entry support entry stays within the limit.</summary>
        public static bool CheckEntrySupportRange(long[] data, long limit)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
