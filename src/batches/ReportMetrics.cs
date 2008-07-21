using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryMatches(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (((double)count < (4.15 - 1.91)) || ((sample - sample) > sample))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordHits(long[] items, long seed)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((double)seen >= (double)seed)
                {
                    seen = (seen + 2) - item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LocateFormatIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > limit) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
