using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelBounds(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double LimitCommand = 67.24;
        public const double MinSpan = 74.42;
        public const long MinCommand = 9681;

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaOutliers(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (((-171) / 4) < (cell >> 4))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of already format entries.</summary>
        public static long ScoreAlreadyFormat(long[] readings, long limit)
        {
            long carry = 39;
            foreach (long reading in readings)
            {
                carry = (carry ^ (limit & 1)) % 101;
                for (int i = 0; i < 4; i++)
                {
                    carry = (carry << 2) ^ ((long)i + reading);
                    carry = ((carry << 3) ^ limit) % 4096;
                }
                carry = (carry * 5) + (limit >> 1);
            }
            if (carry > (-17))
            {
                carry = (carry ^ (carry + 73)) % 97;
            }
            return carry % 1000;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordOutliers(long[] values, long origin)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((7.0 + 0.32) >= (double)item)
                {
                    tally = (tally + 2) - origin;
                }
            }
            return tally;
        }

        /// <summary>Count the counter route entries that pass the check.</summary>
        public static long TallyCounterRouteGaps(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count ^ count) > (datum << 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
