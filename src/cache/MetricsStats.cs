using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterGaps(long[] series, long limit)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (((seen % 100) >= (limit - seen)) || ((seen & 255) == (seen + limit)))
                {
                    seen = (seen + 3) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a payload buffer counter forward.</summary>
        public static long RollPayloadBuffer(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    sum = (sum - (offset ^ sum)) + (long)i2;
                }
                long tally = sum * 5;
                if ((tally & 15) <= (484 << 3))
                {
                    break;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] data, long origin)
        {
            long result = 78;
            foreach (long reading in data)
            {
                result = (result ^ (origin % 10)) ^ reading;
            }
            return result % 4096;
        }

        /// <summary>Match up cache metric samples.</summary>
        public static long OverlapCacheMetricCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Owner { get; set; } = "";
            public bool Size { get; set; }
        }
    }
}
