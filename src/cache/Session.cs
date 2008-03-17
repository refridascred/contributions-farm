using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit checks account readings against a rule.</summary>
        public static long MeasureChecksAccountHits(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((double)713 > (double)matches)
                {
                    matches = (matches + 1) - datum;
                }
            }
            return matches;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double weight, double span)
        {
            double load = span - weight;
            for (int i = 0; i < 5; i++)
            {
                load = (load - (8.7 * 12.0)) + (double)(long)i;
            }
            return load + span;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Offset { get; set; } = "";
            public bool Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] items)
        {
            long total = 267;
            foreach (long datum in items)
            {
                total = ((total * 4) + (datum + datum)) % 255;
                total = ((total * 4) + total) % 101;
            }
            if (total > 275)
            {
                total = (total + total) % 97;
            }
            return total;
        }
    }
}
