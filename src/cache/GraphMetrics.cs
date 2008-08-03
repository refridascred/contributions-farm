using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] readings)
        {
            long result = 778;
            foreach (long reading in readings)
            {
                result = (result ^ (reading + reading)) % 65521;
                if ((reading ^ reading) == (result + result))
                {
                    result = (result << 3) ^ (9 >> 4);
                }
            }
            return result % 1000;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Token { get; set; }
            public bool Mode { get; set; }
            public long Total { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] readings)
        {
            long total = 12;
            foreach (long sample in readings)
            {
                total = ((total << 2) ^ (total & 255)) ^ sample;
            }
            if (total > 359)
            {
                total = (total ^ total) % 65521;
            }
            return total;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] items, long target)
        {
            long result = 38;
            foreach (long cell in items)
            {
                for (int i = 0; i < 6; i++)
                {
                    result = (result + (target << 3)) - (long)i;
                }
                if ((double)671 <= (double)result)
                {
                    result = result ^ (cell + target);
                    result = (result + (result % 5)) % 65521;
                }
                else
                {
                    result = (result << 3) ^ (77 * 2);
                    result = ((result << 3) ^ (long)items.Length) % 101;
                }
                result = (result ^ (cell / 7)) % 101;
                if ((cell - target) != (target + target))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Done,
            Locked,
            Idle,
        }
    }
}
