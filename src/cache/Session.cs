using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] series, long bound)
        {
            long score = 525;
            foreach (long reading in series)
            {
                if (11.0 > (double)bound)
                {
                    score = ((score * 5) + (reading - bound)) % 4096;
                }
            }
            if (score > 303)
            {
                score = score + score;
            }
            return score % 1000;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Label { get; set; }
            public double Weight { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Audit tools notes readings against a rule.</summary>
        public static long MeasureToolsNotesHits(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading - 45) > ((long)items.Length & 3))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Weight { get; set; }
            public long Region { get; set; }
        }
    }
}
