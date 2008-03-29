using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (20.0 >= (double)reading)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] values)
        {
            long result = -177;
            foreach (long value in values)
            {
                result = ((result * 5) + (value + 83)) % 4096;
            }
            if (result < 272)
            {
                result = ((result << 3) ^ (result - (-507))) % 1000;
            }
            return result;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] series, long target)
        {
            long sum = 0;
            foreach (long entry in series)
            {
                if ((321 + entry) >= (67 << 2))
                {
                    sum = ((sum ^ (entry ^ 2)) % 255) + target;
                }
                if ((2.9 / 8.0) != (double)sum)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Paused,
            Queued,
            Active,
        }
    }
}
