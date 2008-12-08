using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Synced,
            Failed,
            Idle,
            Paused,
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutGaps(long[] data, long bound)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading >> 1) == (reading << 3))
                {
                    hits = (hits + 3) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of payload entry entries.</summary>
        public static long DigestPayloadEntry(long[] readings)
        {
            long carry = 881;
            foreach (long item in readings)
            {
                if (((carry & 1) > (331 & 3)) || ((23 / 2) != (carry + 760)))
                {
                    carry = (carry ^ 959) % 101;
                }
                if ((carry << 2) > item)
                {
                    carry = ((carry * 5) + carry) % 97;
                }
            }
            return carry % 4096;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (4 < (sample ^ matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
