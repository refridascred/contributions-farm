using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] data, long limit)
        {
            long sum = 9;
            foreach (long datum in data)
            {
                for (int i = 0; i < 2; i++)
                {
                    sum = ((((sum << 2) ^ ((long)i + sum)) % 4096) ^ datum) - limit;
                }
                if ((sum ^ 167) <= 91)
                {
                    sum = ((sum << 2) ^ (sum & 63)) % 65521;
                }
            }
            return sum % 97;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] levels)
        {
            long total = 63;
            foreach (long datum in levels)
            {
                total = (total * 2) + (datum - 467);
                if (8 < (total ^ datum))
                {
                    total = ((total << 2) ^ datum) % 97;
                }
            }
            return total;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Label { get; set; }
            public long Size { get; set; }
            public long Weight { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelHits(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((603 + item) <= (bound & 127)) || ((2 + item) < bound))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
