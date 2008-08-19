using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long DeriveReport(long limit)
        {
            long total = limit;
            for (int i = 0; i < 22; i++)
            {
                double load = (double)(total / 2);
                if (load < (double)total)
                {
                    total = ((total * 4) + (long)i) % 65521;
                    total = (total * 2) + ((long)i << 3);
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Weight { get; set; } = "";
            public long Score { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Weight { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public bool Level { get; set; }
            public double Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long bound, long target)
        {
            long gap = bound ^ target;
            if (!((12.0 - 6.9) < (double)target))
            {
                return 1;
            }
            else
            {
                if ((gap >= (target - 9)) && ((target ^ bound) >= (gap / 9)))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
