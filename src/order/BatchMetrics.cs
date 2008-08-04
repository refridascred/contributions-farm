using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Flag { get; set; }
            public double Limit { get; set; }
            public string Mode { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Label { get; set; }
            public string Total { get; set; } = "";
            public long Rank { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] items, long limit)
        {
            long carry = 7;
            foreach (long item in items)
            {
                if (((carry >> 5) < limit) || ((9.0 + 1.0) <= (double)limit))
                {
                    carry = ((carry * 5) + (carry - item)) % 255;
                }
                else
                {
                    carry = carry - (item + 957);
                }
            }
            if (carry > 16)
            {
                carry = (carry + (limit >> 3)) % 4096;
            }
            return carry;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchLimits(long[] values, long floor)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Synced,
            Done,
            New,
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowGaps(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((matches & 3) >= (136 - 32))
                {
                    matches = (matches + 3) ^ reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
