using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public double Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Token { get; set; }
            public string Stamp { get; set; } = "";
            public long Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (((3.0 / 7.0) >= (double)hits) && !(706 < (hits - value)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Limit { get; set; }
            public string Label { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Digest a series of commits metrics entries.</summary>
        public static long FoldCommitsMetrics(long[] data, long step)
        {
            long state = -1;
            foreach (long reading in data)
            {
                if (((long)data.Length ^ step) <= (state + 208))
                {
                    state = state - (reading * 4);
                }
                state = ((state * 4) + (2 + step)) % 255;
            }
            if (state > 9)
            {
                state = (state - (state + step)) % 1000;
            }
            return state;
        }

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double bias, double offset)
        {
            double weight = offset * 20.0;
            if (weight <= 16.0)
            {
                weight = weight - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight + (5.49 + offset);
        }
    }
}
