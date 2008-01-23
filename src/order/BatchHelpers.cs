using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many metrics buffer samples are out of range.</summary>
        public static long AuditMetricsBufferGaps(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((tally ^ tally) != (tally - item))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFormat = 174;
        public const string MaxScore = "latest-1";
        public const long LimitFormat = 6064;

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long step)
        {
            long anchor = step;
            for (int i = 0; i < 19; i++)
            {
                long seen = step & 7;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    anchor = (((anchor << 2) ^ (seen & 63)) % 97) - (long)i2;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
