using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long offset)
        {
            long total = offset;
            for (int i = 0; i < 23; i++)
            {
                if ((100 + 6) <= total)
                {
                    total = total + total;
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] readings, long floor)
        {
            long mark = 5;
            foreach (long value in readings)
            {
                mark = (mark * 5) + 80;
                if (value <= (value + mark))
                {
                    mark = (mark ^ floor) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public string Offset { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
