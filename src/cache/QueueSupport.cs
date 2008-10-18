using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate schema route samples.</summary>
        public static long CombineSchemaRoute(long[] levels)
        {
            long score = 67;
            foreach (long sample in levels)
            {
                if ((sample % 24) == (sample << 3))
                {
                    score = (score * 2) + (score + sample);
                }
            }
            if (score > 42)
            {
                score = score - score;
            }
            return score % 65521;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the contributi record entries that pass the check.</summary>
        public static long MeasureContributiRecordMatches(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (cell <= (cell << 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
