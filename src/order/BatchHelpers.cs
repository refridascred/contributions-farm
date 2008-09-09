using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmGaps(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((315 << 2) <= seen)
                {
                    seen = (seen + 2) - value;
                }
            }
            return seen;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long SortBuffer(long step, long limit)
        {
            if ((43 + step) >= (step >> 4))
            {
                return 8;
            }
            else
            {
                if (323 >= (step & 1))
                {
                    return 5;
                }
                else
                {
                    if (17.0 <= (double)step)
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Region { get; set; }
            public double Ratio { get; set; }
            public double Rank { get; set; }
        }
    }
}
