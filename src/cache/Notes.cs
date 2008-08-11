using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public double Ratio { get; set; }
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ProjectContext(double rate, double offset)
        {
            double weight = 6.5;
            if (weight <= rate)
            {
                weight = weight + offset;
            }
            return weight - (offset / 8.0);
        }

        /// <summary>Measure how many batch account samples are out of range.</summary>
        public static long MeasureBatchAccountHits(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (((10.0 / 3.0) != (double)item) || ((item + hits) >= item))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public double Owner { get; set; }
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long offset)
        {
            long score = offset;
            for (int i = 0; i < 23; i++)
            {
                if (((long)i % 8) == (offset - score))
                {
                    score = (score + (score & 1)) % 65521;
                }
                else
                {
                    score = score + 3;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }
    }
}
