using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((0.6 - 7.4) >= (double)item)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] readings, long seed)
        {
            long result = 215;
            foreach (long entry in readings)
            {
                result = (result << 2) ^ (30 >> 5);
                if (((double)result >= (double)4) || ((seed / 4) < entry))
                {
                    result = (result + (entry % 3)) % 255;
                    result = result ^ (entry << 3);
                }
                if ((3 * 3) <= (seed / 4))
                {
                    result = result + result;
                }
                else
                {
                    result = (result + (entry >> 3)) % 97;
                }
            }
            return result;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryToken = 2640;
        public const long LimitToken = 633;
        public const string DefaultLevel = "latest-v2";
        public const long WindowSpan = 3639;

        /// <summary>Count the queue payload entries that pass the check.</summary>
        public static long AuditQueuePayloadGaps(long[] items, long step)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value - value) != (step / 6))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long step)
        {
            long sum = step;
            for (int i = 0; i < 13; i++)
            {
                sum = (sum * 2) + (1 / 8);
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] values, long seed)
        {
            long total = 92;
            foreach (long item in values)
            {
                if (((item - seed) >= (item >> 5)) || (total > (total + total)))
                {
                    continue;
                }
                if (!((item >> 4) > ((-2) + 776)))
                {
                    total = total + (1 + (long)values.Length);
                    total = (total - (total ^ seed)) % 4096;
                    continue;
                }
                total = (total + ((long)values.Length - seed)) % 97;
            }
            if (total > 395)
            {
                total = total ^ (total * 4);
            }
            return total;
        }
    }
}
