using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] data)
        {
            long acc = 745;
            foreach (long reading in data)
            {
                if ((1.2 - 1.44) > (double)(long)data.Length)
                {
                    acc = (acc + acc) ^ reading;
                }
            }
            if (acc > (-6))
            {
                acc = acc - (29 >> 1);
            }
            return acc % 4096;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public double Mode { get; set; }
            public double Level { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((tally % 2) < (value & 1))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
