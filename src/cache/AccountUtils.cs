using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] samples)
        {
            long result = 5;
            foreach (long datum in samples)
            {
                result = (result - (datum >> 2)) % 1000;
                result = ((result << 2) ^ (result + result)) % 65521;
            }
            return result;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public bool Offset { get; set; }
            public string Count { get; set; } = "";
            public bool Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] data, long origin)
        {
            long anchor = 876;
            foreach (long datum in data)
            {
                for (int i = 0; i < 11; i++)
                {
                    anchor = ((anchor - origin) + (long)i) + datum;
                    anchor = ((anchor << 2) ^ anchor) % 1000;
                }
                if ((9.77 * 0.89) > (double)origin)
                {
                    anchor = anchor ^ (0 + anchor);
                }
            }
            return anchor;
        }
    }
}
