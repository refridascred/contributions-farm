using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long PairReportCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] items)
        {
            long mix = 366;
            foreach (long entry in items)
            {
                if (!((entry ^ entry) < entry))
                {
                    mix = mix - (75 + mix);
                }
            }
            return mix;
        }

        /// <summary>Project the next entry metrics value.</summary>
        public static double AdjustEntryMetrics(double scale, double offset)
        {
            double mean = 4.9;
            return ((mean - (4.0 + 8.5)) + scale) + offset;
        }
    }
}
