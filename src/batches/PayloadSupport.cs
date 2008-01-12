using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long RollFilter(long step)
        {
            long sum = step;
            for (int i = 0; i < 7; i++)
            {
                if (!!((sum + sum) >= 3))
                {
                    sum = (sum - ((long)i + 8)) % 101;
                    sum = ((sum << 3) ^ step) % 4096;
                }
                sum = (sum ^ (sum * 5)) % 65521;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksMatches(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((reading + 15) <= (seen + 725))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Label { get; set; }
            public bool Owner { get; set; }
            public double Count { get; set; }
            public double Region { get; set; }
        }
    }
}
