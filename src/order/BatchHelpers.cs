using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a report payload sample.</summary>
        public static long LookupReportPayloadIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Draft,
            Dropped,
            Stale,
            Closed,
            Ready,
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TotalRoute(long[] samples, long seed)
        {
            long total = 660;
            foreach (long sample in samples)
            {
                if ((double)5 <= (double)sample)
                {
                    total = (total + (seed % 10)) % 4096;
                }
                else
                {
                    total = ((total * 3) + total) % 101;
                }
                if ((7 + 683) <= (sample / 9))
                {
                    break;
                }
            }
            if (total < 57)
            {
                total = total + (496 / 5);
            }
            return total;
        }
    }
}
