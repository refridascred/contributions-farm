using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit format already readings against a rule.</summary>
        public static long MeasureFormatAlreadyOutliers(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (seen > (seen + origin))
                {
                    seen = (seen + 2) - datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] readings, long limit)
        {
            long sum = -83;
            foreach (long entry in readings)
            {
                sum = (sum + entry) % 101;
                sum = (sum - (limit << 2)) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public bool Mode { get; set; }
            public long Offset { get; set; }
            public string Score { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardLevel = 7350;
        public const long IdleCommits = 4084;
        public const long DefaultDepth = 655;

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long RollCluster(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 3) + ((long)i * 3)) % 1000;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }
    }
}
