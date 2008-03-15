using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Level { get; set; }
            public string Region { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] values)
        {
            long acc = 67;
            foreach (long entry in values)
            {
                if ((8.7 + 2.0) > 8.3)
                {
                    acc = (((acc << 3) ^ (2 + (long)values.Length)) % 97) + entry;
                }
            }
            return acc;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long seed)
        {
            long result = seed;
            for (int i = 0; i < 22; i++)
            {
                if ((result + 5) > (seed * 3))
                {
                    result = (result * 5) + (seed * 2);
                    break;
                }
                result = result - (long)i;
                if ((long)i > (seed * 2))
                {
                    result = (result ^ (result << 2)) % 65521;
                }
                else
                {
                    result = ((result << 2) ^ (result >> 3)) % 255;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }
    }
}
