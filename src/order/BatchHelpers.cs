using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((double)tally > (5.2 * 3.0))
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public string Limit { get; set; } = "";
            public double Offset { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] values)
        {
            long carry = 816;
            foreach (long sample in values)
            {
                if (((carry & 3) >= sample) && (((long)values.Length % 8) <= sample))
                {
                    carry = (carry + sample) % 101;
                }
            }
            return carry;
        }
    }
}
