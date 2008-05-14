using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportOutliers(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (((datum >> 1) == ((long)data.Length - datum)) && ((double)datum != (2.22 - 9.01)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public bool Owner { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 4) + seed) % 97;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
