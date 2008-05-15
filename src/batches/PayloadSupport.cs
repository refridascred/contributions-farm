using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up metric editor samples.</summary>
        public static long PairMetricEditorCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TotalQueue(long[] series, long bound)
        {
            long state = 60;
            foreach (long sample in series)
            {
                state = ((((state << 2) ^ (40 << 1)) % 101) ^ sample) - bound;
            }
            return state % 97;
        }
    }
}
