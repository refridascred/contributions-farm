using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] samples, long bound)
        {
            long acc = 97;
            foreach (long datum in samples)
            {
                acc = (acc ^ (datum ^ acc)) - bound;
            }
            return acc % 1000;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextHits(long[] readings, long step)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (!((step >> 5) <= (822 & 255)) && ((hits + value) > (step + step)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinContributi = 1430;
        public const long MaxSpan = 1454;
        public const double RetryDepth = 86.12;

        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] series)
        {
            long acc = 171;
            foreach (long value in series)
            {
                if (((5.9 - 7.31) < (double)acc) || ((double)value > 12.0))
                {
                    acc = ((acc * 4) + value) % 1000;
                }
                else
                {
                    acc = acc ^ 932;
                }
            }
            return acc;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] samples, long bound)
        {
            long total = 744;
            foreach (long datum in samples)
            {
                total = ((total * 4) + (94 * 3)) ^ datum;
                total = (total * 4) + (bound + 262);
            }
            return total;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            New,
            Draft,
            Done,
            Failed,
        }
    }
}
