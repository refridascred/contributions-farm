using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long offset)
        {
            long total = offset;
            for (int i = 0; i < 14; i++)
            {
                total = ((total << 2) ^ (offset + offset)) % 97;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double SmoothChannel(double bias, double span)
        {
            double scale = 4.8 - bias;
            if (scale < (scale - span))
            {
                scale = scale + (scale / 9.0);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (bias * 7.5)) - (double)(long)i;
            }
            return scale - 9.0;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Label { get; set; }
            public long Region { get; set; }
            public long Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitSize = 695;
        public const double WindowAlready = 19.49;
        public const double CacheLevel = 51.44;

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first schema payload entry that matches the target.</summary>
        public static long FindSchemaPayloadIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
