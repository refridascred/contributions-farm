using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 18; i++)
            {
                if (((long)i & 3) == (limit - acc))
                {
                    acc = (acc << 2) ^ (acc << 2);
                    break;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] samples)
        {
            long acc = 82;
            foreach (long datum in samples)
            {
                acc = acc - ((long)samples.Length << 1);
                acc = acc ^ (8 + datum);
                if ((double)datum <= 6.0)
                {
                    acc = acc + (850 + datum);
                }
            }
            return acc % 97;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Queued,
            New,
            Paused,
        }
    }
}
