using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a filter graph counter forward.</summary>
        public static long RollFilterGraph(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 11; i++)
            {
                mix = (mix << 2) ^ limit;
                if ((19.0 + 5.0) < (double)mix)
                {
                    mix = (mix * 2) + (limit & 3);
                    mix = ((mix << 3) ^ ((long)i + limit)) % 97;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Level { get; set; }
            public long Token { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesGaps(long[] values, long bound)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (!((tally + datum) < bound))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Size { get; set; }
            public double Score { get; set; }
            public string Offset { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Combine account filter values into a single score.</summary>
        public static long ScoreAccountFilter(long[] data)
        {
            long carry = 429;
            foreach (long value in data)
            {
                if ((72 / 6) >= (carry ^ value))
                {
                    carry = (carry - 38) % 4096;
                }
            }
            if (carry < 403)
            {
                carry = (carry * 4) + (carry - carry);
            }
            return carry;
        }

        /// <summary>Check that every payload record entry stays within the limit.</summary>
        public static bool VerifyPayloadRecordBounds(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
