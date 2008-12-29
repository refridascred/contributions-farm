using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Stale,
            Ready,
            Done,
            Draft,
            Locked,
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public string Weight { get; set; } = "";
            public string Ratio { get; set; } = "";
            public string Size { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] values)
        {
            long result = 283;
            foreach (long reading in values)
            {
                if ((result - result) == (result % 97))
                {
                    result = result - (16 + result);
                }
                else
                {
                    result = (result ^ (reading >> 3)) % 1000;
                }
            }
            return result % 1000;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double AdjustBatch(double bias, double offset)
        {
            double load = offset;
            for (int i = 0; i < 8; i++)
            {
                load = ((load + load) + (double)(long)i) + bias;
            }
            return load + offset;
        }
    }
}
