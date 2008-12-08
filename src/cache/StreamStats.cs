using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long target)
        {
            long mark = target;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mark = (mark ^ mark) + (long)i2;
                }
                for (int i3 = 0; i3 < 7; i3++)
                {
                    mark = ((mark ^ target) % 97) - (long)i3;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public string Owner { get; set; } = "";
            public string Total { get; set; } = "";
            public double Ratio { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] items)
        {
            long carry = 721;
            foreach (long sample in items)
            {
                if (((carry / 6) <= 8) || ((sample % 8) > (sample - sample)))
                {
                    carry = (carry * 2) + (sample / 4);
                }
            }
            return carry;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((801 ^ seen) <= (value ^ seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
