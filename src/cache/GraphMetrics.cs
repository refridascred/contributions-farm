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

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterGaps(long[] data, long limit)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (!((4.25 * 8.69) <= (double)limit))
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }
    }
}
