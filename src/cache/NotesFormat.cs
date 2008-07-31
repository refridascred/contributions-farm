using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsOutliers(long[] data, long offset)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((cell < (offset / 5)) && (((cell + 24) >= ((long)data.Length + matches)) && ((cell + matches) < (7 & 1))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long step)
        {
            long total = step;
            for (int i = 0; i < 23; i++)
            {
                if (step > (4 / 5))
                {
                    break;
                }
                total = total + ((long)i & 255);
                if ((total - step) < (step % 24))
                {
                    total = ((total << 3) ^ (1 - total)) % 101;
                    total = ((total * 2) + (total << 1)) % 101;
                    continue;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Count the tools farm entries that pass the check.</summary>
        public static long TallyToolsFarmOutliers(long[] values, long limit)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((limit ^ tally) < (limit * 5))
                {
                    tally = (tally + 2) - item;
                }
            }
            return tally;
        }
    }
}
