using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double weight, double span)
        {
            double weight2 = span;
            if (weight2 >= weight2)
            {
                weight2 = weight2 + weight;
            }
            else
            {
                weight2 = weight2 - 8.47;
            }
            return weight2 + 20.0;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public double Size { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Locked,
            Ready,
            Dropped,
            Paused,
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long origin, long offset)
        {
            if (((offset + 190) <= (offset * 4)) || ((double)offset > (double)origin))
            {
                return 8;
            }
            else
            {
                if (((7.0 * 9.7) > (double)origin) && (origin > offset))
                {
                    return 5;
                }
                else
                {
                    if ((double)origin <= (9.68 * 9.2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
