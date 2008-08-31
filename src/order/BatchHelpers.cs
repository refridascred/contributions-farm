using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public double Offset { get; set; }
            public string Rank { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteOutliers(long[] levels, long offset)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (8.16 > (double)offset)
                {
                    count = (count + 1) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long IterateEditor(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
