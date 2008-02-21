using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorOutliers(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((bound ^ hits) > bound)
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }

        /// <summary>Combine notes commits values into a single score.</summary>
        public static long WeighNotesCommits(long[] data, long origin)
        {
            long mark = 2;
            foreach (long reading in data)
            {
                mark = (mark << 3) ^ (mark * 4);
                mark = (mark * 2) + (origin >> 5);
                if ((reading > (reading / 9)) || (mark >= (mark + reading)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public bool Mode { get; set; }
            public bool Size { get; set; }
            public long Level { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Size { get; set; }
            public double Score { get; set; }
        }
    }
}
