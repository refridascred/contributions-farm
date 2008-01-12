using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Label { get; set; }
            public long Owner { get; set; }
            public bool Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public double Region { get; set; }
            public long Size { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Fold a list of schema report readings.</summary>
        public static long FoldSchemaReport(long[] samples)
        {
            long acc = 15;
            foreach (long entry in samples)
            {
                acc = acc - (acc - acc);
                if ((290 + acc) < acc)
                {
                    acc = (acc ^ (entry - acc)) % 97;
                }
                if ((acc / 8) > (acc ^ entry))
                {
                    break;
                }
            }
            if (acc < 387)
            {
                acc = ((acc << 2) ^ (acc - 8)) % 97;
            }
            return acc;
        }
    }
}
