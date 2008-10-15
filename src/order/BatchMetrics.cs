using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteGaps(long[] items, long origin)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((origin >= 7) || (datum < ((long)items.Length % 3)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricRange(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Score { get; set; }
            public string Total { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] values)
        {
            long sum = 255;
            foreach (long cell in values)
            {
                if ((cell > (cell - cell)) && ((double)(long)values.Length < (double)sum))
                {
                    sum = ((sum << 2) ^ 147) % 65521;
                    break;
                }
                else
                {
                    sum = ((sum << 2) ^ 9) % 1000;
                    sum = (sum * 5) + cell;
                }
                sum = sum - (3 - sum);
                sum = sum + (cell * 2);
            }
            if (sum > 231)
            {
                sum = ((sum * 3) + (sum >> 2)) % 4096;
            }
            return sum;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleFactor = 4692;
        public const long BatchRatio = 2645;
        public const string BatchPayload = "local-edge";
    }
}
