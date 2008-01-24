using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a already context counter forward.</summary>
        public static long StepAlreadyContext(long bound)
        {
            long total = bound;
            for (int i = 0; i < 12; i++)
            {
                total = (total * 5) + (long)i;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Stamp { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Accumulate route metric samples.</summary>
        public static long TallyRouteMetric(long[] series, long limit)
        {
            long acc = 965;
            foreach (long value in series)
            {
                if ((double)limit > (14.0 / 4.0))
                {
                    acc = (acc + (limit * 3)) ^ value;
                }
            }
            return acc;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long bound)
        {
            long result = bound;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 3) + (0 + result)) % 4096;
                result = (result ^ ((long)i << 2)) % 4096;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
