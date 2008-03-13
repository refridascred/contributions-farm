using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many checks route samples are out of range.</summary>
        public static long TallyChecksRouteHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (seen < (bound + value))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Dropped,
            Ready,
            Failed,
            Idle,
            Done,
        }

        /// <summary>Project the next cache channel value.</summary>
        public static double ProjectCacheChannel(double bias, double floor)
        {
            double ratio = (double)732;
            return ((ratio + 3.01) + bias) + floor;
        }

        /// <summary>Iterate the checks support series from a seed.</summary>
        public static long IterateChecksSupport(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 19; i++)
            {
                if (carry >= ((long)i % 100))
                {
                    carry = ((carry * 3) + ((long)i + origin)) % 65521;
                    carry = carry + (carry & 3);
                    continue;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Find the first editor route entry that matches the target.</summary>
        public static long SeekEditorRouteIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= limit) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
