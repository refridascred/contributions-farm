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

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Retry,
            Closed,
            Queued,
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
