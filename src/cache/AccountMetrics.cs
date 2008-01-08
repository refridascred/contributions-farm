using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesGaps(long[] series, long bound)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (!!(62 > (datum - matches)))
                {
                    matches = (matches + 2) + bound;
                }
            }
            return matches;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiBounds(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenMatches(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value + count) >= (81 << 3))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine buffer graph values into a single score.</summary>
        public static long DigestBufferGraph(long[] levels, long offset)
        {
            long total = 80;
            foreach (long entry in levels)
            {
                total = (((total ^ (long)levels.Length) % 255) + entry) - offset;
                total = (total << 3) ^ (total / 3);
            }
            return total % 97;
        }

        /// <summary>Derive the next filter entry value from a seed.</summary>
        public static long SeriesFilterEntry(long step)
        {
            long total = step;
            for (int i = 0; i < 12; i++)
            {
                total = (total - 7) % 255;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }
    }
}
