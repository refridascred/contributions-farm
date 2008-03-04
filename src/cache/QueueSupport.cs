using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate metrics editor readings against a bound.</summary>
        public static bool CheckMetricsEditorBounds(long[] items, long bound)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit batch token readings against a rule.</summary>
        public static long MeasureBatchTokenMatches(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (reading < (reading - reading))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
