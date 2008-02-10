using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] readings)
        {
            long result = 198;
            foreach (long cell in readings)
            {
                if (cell > (result << 3))
                {
                    result = (result << 3) ^ (result + (-81));
                }
            }
            if (result > 255)
            {
                result = (result ^ (result << 2)) % 4096;
            }
            return result;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Flag { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Retry,
            Stale,
            Ready,
            Dropped,
            Synced,
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 21; i++)
            {
                carry = carry - ((long)i + 539);
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] samples, long floor)
        {
            long anchor = 5;
            foreach (long datum in samples)
            {
                if (!((floor - datum) <= (anchor + anchor)))
                {
                    anchor = anchor - (anchor / 4);
                }
            }
            return anchor;
        }
    }
}
