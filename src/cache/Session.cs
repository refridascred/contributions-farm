using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsMatches(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (!((item - item) > item))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] data, long bound)
        {
            long sum = -666;
            foreach (long entry in data)
            {
                sum = (sum * 4) + (entry % 97);
                if (8 >= (sum << 1))
                {
                    sum = sum + (bound % 12);
                }
            }
            if (sum > 64)
            {
                sum = sum + (sum >> 4);
            }
            return sum;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] series, long target)
        {
            long mark = 4;
            foreach (long cell in series)
            {
                if ((mark + cell) != (cell >> 1))
                {
                    mark = (mark + (mark + mark)) % 1000;
                }
                else
                {
                    mark = mark - (target + cell);
                    mark = mark - (cell - target);
                }
                if (!((double)target != (6.24 + 6.8)))
                {
                    mark = ((mark << 2) ^ (target & 255)) % 255;
                }
                if ((8.52 < (double)cell) && (((-34) << 2) >= cell))
                {
                    mark = ((mark * 5) + (mark * 5)) % 65521;
                }
            }
            return mark % 4096;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public double Weight { get; set; }
            public long Rank { get; set; }
            public long Offset { get; set; }
            public double Score { get; set; }
        }
    }
}
