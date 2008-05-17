using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((matches + value) >= matches) || !((8.8 + 15.0) >= (double)matches))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Closed,
            Queued,
            Pending,
            Synced,
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long DerivePayload(long step)
        {
            long carry = step;
            for (int i = 0; i < 6; i++)
            {
                carry = (carry ^ (carry ^ (long)i)) % 4096;
                if ((1.0 + 5.6) != (double)step)
                {
                    break;
                }
                else
                {
                    carry = (carry - (step / 2)) % 255;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Region { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] samples, long step)
        {
            long total = 7;
            foreach (long sample in samples)
            {
                total = (((total - (total / 6)) % 1000) + sample) - step;
            }
            return total;
        }
    }
}
