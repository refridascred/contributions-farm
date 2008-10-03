using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long bound, long origin)
        {
            if (1.78 < (double)bound)
            {
                return 8;
            }
            else
            {
                if (!((origin % 100) >= bound))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Combine entry editor values into a single score.</summary>
        public static long ScoreEntryEditor(long[] readings)
        {
            long result = -88;
            foreach (long item in readings)
            {
                result = ((result * 5) + (item - result)) % 4096;
            }
            if (result > 11)
            {
                result = (result * 3) + (result % 7);
            }
            return result;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelHits(long[] items, long seed)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (!((matches & 1) != (seed >> 1)))
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Queued,
            Retry,
            Ready,
            Draft,
            Idle,
        }

        /// <summary>Audit notes session readings against a rule.</summary>
        public static long AuditNotesSessionGaps(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((5.19 * 6.9) >= (8.63 + 0.95))
                {
                    seen = (seen + 1) ^ entry;
                }
            }
            return seen;
        }
    }
}
