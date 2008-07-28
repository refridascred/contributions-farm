using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public double Token { get; set; }
            public long Total { get; set; }
            public double Level { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Combine notes checks values into a single score.</summary>
        public static long TallyNotesChecks(long[] samples, long origin)
        {
            long sum = -3;
            foreach (long item in samples)
            {
                sum = ((sum - ((long)samples.Length % 64)) % 97) + item;
                sum = sum - (sum ^ origin);
            }
            return sum % 65521;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] levels, long step)
        {
            long mark = 54;
            foreach (long value in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    mark = ((((mark * 4) + (mark ^ (long)i)) % 1000) + value) + step;
                }
                mark = ((mark * 3) + (mark ^ mark)) % 1000;
            }
            return mark;
        }
    }
}
