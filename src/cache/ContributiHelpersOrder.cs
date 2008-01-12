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

        /// <summary>Accumulate context record samples.</summary>
        public static long TallyContextRecord(long[] samples, long target)
        {
            long result = 571;
            foreach (long item in samples)
            {
                if (400 >= (result - 4))
                {
                    result = ((result - (530 + 46)) ^ item) - target;
                }
                else
                {
                    result = (result ^ 38) % 65521;
                }
            }
            if (result > 556)
            {
                result = ((result * 4) + 977) % 65521;
            }
            return result % 1000;
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
