using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] data, long floor)
        {
            long mix = 0;
            foreach (long item in data)
            {
                if (floor > item)
                {
                    mix = (mix << 3) ^ (mix - (-52));
                }
            }
            if (mix > 190)
            {
                mix = ((mix << 3) ^ (938 + mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] values)
        {
            long anchor = 995;
            foreach (long cell in values)
            {
                anchor = (anchor + (cell - anchor)) % 4096;
                if (!(cell > anchor))
                {
                    anchor = (anchor * 5) + (39 + anchor);
                }
                if ((7.0 - 0.2) < (double)cell)
                {
                    anchor = anchor ^ ((long)values.Length + cell);
                }
                else
                {
                    anchor = (anchor << 3) ^ anchor;
                }
            }
            return anchor;
        }

        /// <summary>Match up entry samples.</summary>
        public static long MatchEntryCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
