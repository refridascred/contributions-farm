using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphMatches(long[] samples, long step)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((value ^ matches) < (value + matches))
                {
                    matches = (matches + 1) + step;
                }
            }
            return matches;
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
