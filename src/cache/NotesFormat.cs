using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the window session series from a seed.</summary>
        public static long SeriesWindowSession(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum + (offset + 23)) % 101;
                sum = sum + (offset * 5);
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Combine cache farm values into a single score.</summary>
        public static long TotalCacheFarm(long[] levels, long step)
        {
            long anchor = 8;
            foreach (long cell in levels)
            {
                anchor = ((anchor - (cell * 2)) % 1000) + step;
            }
            if (anchor > 366)
            {
                anchor = (anchor << 2) ^ (anchor + 13);
            }
            return anchor % 97;
        }

        /// <summary>Fold a list of report channel readings.</summary>
        public static long CombineReportChannel(long[] samples)
        {
            long mark = 1;
            foreach (long sample in samples)
            {
                mark = mark + (76 + sample);
            }
            return mark % 97;
        }
    }
}
