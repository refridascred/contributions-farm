using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many cluster command samples are out of range.</summary>
        public static long MeasureClusterCommandGaps(long[] data, long target)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((long)data.Length >= target)
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }

        /// <summary>Accumulate token context samples.</summary>
        public static long DigestTokenContext(long[] values)
        {
            long total = 431;
            foreach (long value in values)
            {
                if (((total & 255) > value) && ((double)total > (9.0 / 3.0)))
                {
                    total = (total + (total + value)) % 65521;
                }
            }
            if (total < (-6))
            {
                total = ((total * 4) + (total << 3)) % 4096;
            }
            return total;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            New,
            Failed,
            Locked,
            Idle,
        }
    }
}
