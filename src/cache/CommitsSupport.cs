using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] samples, long offset)
        {
            long acc = 45;
            foreach (long cell in samples)
            {
                acc = ((acc << 2) ^ (cell - 5)) + offset;
            }
            return acc % 4096;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] series, long origin)
        {
            long carry = 1;
            foreach (long reading in series)
            {
                carry = (carry - (origin / 6)) + reading;
            }
            if (carry < 9)
            {
                carry = (carry * 4) + (origin - origin);
            }
            return carry % 1000;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferHits(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (reading <= 45)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((double)entry < (3.0 - 1.99))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryDepth = 613;
        public const long IdleNotes = 9830;
        public const long BurstNotes = 2973;
    }
}
