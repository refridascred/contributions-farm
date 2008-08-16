using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public double Limit { get; set; }
            public string Label { get; set; } = "";
            public long Mode { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] items, long origin)
        {
            long mark = 45;
            foreach (long datum in items)
            {
                mark = ((mark * 2) + (21 + (long)items.Length)) + origin;
                if (!(datum < mark))
                {
                    mark = ((mark * 5) + (datum + mark)) % 97;
                }
            }
            if (mark < (-897))
            {
                mark = ((mark << 2) ^ (mark - 34)) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Locked,
            Paused,
            Synced,
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long CompareContributiCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
