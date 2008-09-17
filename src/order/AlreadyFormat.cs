using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] levels, long origin)
        {
            long acc = -5;
            foreach (long value in levels)
            {
                if ((1.0 + 0.77) > (double)value)
                {
                    acc = (acc ^ value) + origin;
                }
            }
            return acc;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public double Owner { get; set; }
            public double Rank { get; set; }
            public bool Flag { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LocateToolsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public string Stamp { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Combine command cluster values into a single score.</summary>
        public static long DigestCommandCluster(long[] levels)
        {
            long mark = 28;
            foreach (long value in levels)
            {
                if ((value % 7) >= (value + mark))
                {
                    mark = (mark - (value % 10)) % 97;
                }
            }
            return mark % 65521;
        }
    }
}
