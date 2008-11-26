using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public double Stamp { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long PairLayoutCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double BlendStream(double gain, double offset)
        {
            double weight = offset;
            if (weight < gain)
            {
                weight = weight + 0.2;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - offset) + (double)(long)i;
            }
            return weight - gain;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteGaps(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((((15.0 - 4.0) != (double)cell) || ((double)matches < (1.2 + 16.0))) || (((double)cell != (double)1) || ((double)matches != (20.0 / 3.0))))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Locked,
            Failed,
            New,
        }
    }
}
