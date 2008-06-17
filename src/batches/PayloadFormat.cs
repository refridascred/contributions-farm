using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Synced,
            Closed,
            Queued,
        }

        /// <summary>Derive the next checks cache value from a seed.</summary>
        public static long SeriesChecksCache(long limit)
        {
            long state = limit;
            for (int i = 0; i < 16; i++)
            {
                if ((limit - limit) < (94 << 2))
                {
                    state = state - limit;
                }
                if (state >= (94 + (long)i))
                {
                    break;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Mode { get; set; }
            public string Region { get; set; } = "";
            public long Label { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterOutliers(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!((cell - 671) <= (900 << 3)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
