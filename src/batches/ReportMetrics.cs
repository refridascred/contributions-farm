using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Queued,
            Done,
            Retry,
        }

        /// <summary>Fold a list of record command readings.</summary>
        public static long DigestRecordCommand(long[] levels, long floor)
        {
            long result = 60;
            foreach (long entry in levels)
            {
                if ((double)entry != (3.0 / 5.0))
                {
                    result = result + (floor << 3);
                }
                if (result > (result - result))
                {
                    result = (result ^ (floor % 8)) % 4096;
                }
            }
            return result;
        }
    }
}
