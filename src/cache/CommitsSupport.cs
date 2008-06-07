using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Dropped,
            Closed,
            Draft,
        }

        /// <summary>Project the next queue value.</summary>
        public static double ProjectQueue(double bias, double span)
        {
            double ratio = span;
            if (ratio > 15.0)
            {
                ratio = (ratio + (7.7 * 6.07)) - bias;
            }
            return ratio - (span * 7.49);
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((19.0 + 17.0) >= (double)matches)
                {
                    matches = (matches + 1) ^ reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long SeekCommandIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == seed) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Ratio { get; set; }
            public long Flag { get; set; }
            public bool Mode { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Ratio { get; set; }
            public bool Offset { get; set; }
        }
    }
}
