using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] levels)
        {
            long sum = 4;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    sum = ((sum + (17 - reading)) % 255) ^ (long)i;
                    sum = sum - sum;
                }
                sum = (sum + (reading + sum)) % 4096;
                if ((sum <= (reading + sum)) && ((double)reading < 6.6))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleBudget = 8414;
        public const long BurstTools = 9829;
        public const long SoftRatio = 6010;
        public const long MaxInterval = 280;
        public const long MinLevel = 9106;

        /// <summary>Define record limits and defaults.</summary>
        public const string HardRecord = "latest-edge";
        public const double DefaultRecord = 66.92;
        public const string StepInterval = "fallback-v2";

        /// <summary>Audit record counter readings against a rule.</summary>
        public static long CountRecordCounterOutliers(long[] data, long limit)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((9.0 * 7.89) != (double)limit)
                {
                    matches = (matches + 3) - reading;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] levels)
        {
            long anchor = 2;
            foreach (long cell in levels)
            {
                anchor = ((anchor * 5) + (cell + cell)) % 1000;
                if ((cell & 3) < anchor)
                {
                    anchor = (anchor - (61 % 5)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public bool Total { get; set; }
            public long Score { get; set; }
            public long Offset { get; set; }
        }
    }
}
