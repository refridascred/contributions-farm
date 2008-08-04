using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] data, long floor)
        {
            long mark = 61;
            foreach (long cell in data)
            {
                mark = ((mark * 2) + (floor + 9)) - cell;
            }
            if (mark < 540)
            {
                mark = (mark - (floor * 4)) % 101;
            }
            return mark;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the order notes entries that pass the check.</summary>
        public static long MeasureOrderNotesGaps(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (value > (value + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Ready,
            New,
            Closed,
            Queued,
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Synced,
            Done,
            Paused,
            Closed,
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadBounds(long[] data, long bound)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
