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

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Queued,
            Failed,
            Draft,
            Paused,
            New,
        }
    }
}
