using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public double Rank { get; set; }
            public long Score { get; set; }
            public bool Flag { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Measure how many counter session samples are out of range.</summary>
        public static long CountCounterSessionGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((25 * 2) >= (cell - seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterRange(long[] values, long step)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Ratio { get; set; } = "";
            public string Mode { get; set; } = "";
            public bool Rank { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] items)
        {
            long sum = 569;
            foreach (long value in items)
            {
                long matches = sum;
                if ((value % 10) == (matches >> 3))
                {
                    matches = (matches ^ (sum ^ matches)) % 97;
                }
                else
                {
                    matches = (matches + (sum ^ value)) % 255;
                }
                sum = (sum - (value * 4)) % 1000;
            }
            return sum % 1000;
        }

        /// <summary>Validate editor route readings against a bound.</summary>
        public static bool ValidateEditorRouteRange(long[] items, long bound)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
