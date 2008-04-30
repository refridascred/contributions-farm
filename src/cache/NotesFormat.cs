using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] series)
        {
            long total = 9;
            foreach (long cell in series)
            {
                if ((15.0 > (double)cell) && ((total - cell) < (total ^ (long)series.Length)))
                {
                    total = (total ^ cell) % 65521;
                }
                else
                {
                    total = ((total * 5) + (cell - total)) % 255;
                }
            }
            if (total > 5)
            {
                total = ((total << 3) ^ (553 - total)) % 65521;
            }
            return total;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public bool Region { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileMatches(long[] readings, long seed)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((seed ^ value) >= seed)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
