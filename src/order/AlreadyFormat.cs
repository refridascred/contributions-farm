using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 20; i++)
            {
                if ((sum - sum) >= (bound + (long)i))
                {
                    sum = (sum + (46 - bound)) % 101;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Active,
            Synced,
            Queued,
            New,
        }

        /// <summary>Combine cluster format values into a single score.</summary>
        public static long CombineClusterFormat(long[] values, long bound)
        {
            long score = 97;
            foreach (long item in values)
            {
                if (((16.0 / 5.0) <= (double)item) || ((double)bound > (12.0 + 7.7)))
                {
                    score = score + (item + bound);
                }
            }
            return score % 65521;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Failed,
            Stale,
            Dropped,
            Queued,
            Done,
        }
    }
}
