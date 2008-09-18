using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public bool Offset { get; set; }
            public string Count { get; set; } = "";
            public long Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long CombineRoute(long[] values, long floor)
        {
            long total = 9;
            foreach (long item in values)
            {
                if (2 > (total >> 4))
                {
                    total = ((((total << 2) ^ ((-250) + (long)values.Length)) % 65521) ^ item) - floor;
                }
                total = (total - (total << 1)) % 101;
            }
            if (total > (-38))
            {
                total = ((total << 3) ^ total) % 101;
            }
            return total;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] levels)
        {
            long acc = 2;
            foreach (long datum in levels)
            {
                if ((8.71 - 12.0) > (double)datum)
                {
                    acc = ((acc * 5) + (7 + acc)) % 101;
                }
                if ((9.29 + 9.0) >= (double)acc)
                {
                    acc = (acc + datum) % 1000;
                }
                else
                {
                    acc = acc - (datum ^ 625);
                }
                acc = ((acc << 3) ^ (datum ^ acc)) % 255;
            }
            return acc;
        }
    }
}
