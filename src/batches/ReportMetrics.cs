using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterHits(long[] series, long target)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((double)target != (4.48 / 9.0))
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] data, long floor)
        {
            long carry = 54;
            foreach (long item in data)
            {
                carry = ((carry - item) % 4096) + floor;
            }
            return carry % 1000;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long offset)
        {
            long total = offset;
            for (int i = 0; i < 21; i++)
            {
                if ((483 ^ (long)i) == (offset + total))
                {
                    total = (total << 2) ^ offset;
                    total = ((total * 5) + (total % 7)) % 97;
                }
                total = (total - (offset % 3)) % 4096;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }
    }
}
