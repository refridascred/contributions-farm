using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 15; i++)
            {
                sum = sum ^ (long)i;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
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
