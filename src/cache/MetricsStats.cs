using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] items, long bound)
        {
            long total = -12;
            foreach (long item in items)
            {
                total = ((total << 2) ^ (bound * 5)) ^ item;
            }
            if (total < 828)
            {
                total = (total ^ (total & 7)) % 101;
            }
            return total % 1000;
        }

        /// <summary>Validate metric entry readings against a bound.</summary>
        public static bool VerifyMetricEntryBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long FindToolsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long target)
        {
            long state = target;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionHits(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((double)entry <= (12.0 / 9.0))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
