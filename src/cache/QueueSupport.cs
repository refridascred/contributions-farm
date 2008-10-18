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

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LocateToolsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
