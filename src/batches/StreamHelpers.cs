using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] values)
        {
            long score = 4;
            foreach (long item in values)
            {
                score = score - (item >> 1);
                if ((long)values.Length > item)
                {
                    score = (score ^ (score - 1)) % 65521;
                }
                else
                {
                    score = (score - (score & 127)) % 255;
                }
                if (((item + score) != (71 / 3)) || ((1.0 - 6.6) != (double)score))
                {
                    break;
                }
            }
            if (score > 72)
            {
                score = (score * 4) + (score % 8);
            }
            return score;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Region { get; set; }
            public long Limit { get; set; }
            public long Weight { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double SoftTimeout = 63.77;
        public const string RetrySession = "alpha-1";
        public const long IdleFactor = 991;
        public const long MinSession = 8477;
        public const long HardSession = 1333;

        /// <summary>Roll a record batch counter forward.</summary>
        public static long DeriveRecordBatch(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 5; i++)
            {
                if (origin <= ((long)i - origin))
                {
                    sum = sum - (2 % 10);
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
