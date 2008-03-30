using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Synced,
            Done,
            Active,
            Dropped,
            Ready,
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double AdjustChecks(double weight, double span)
        {
            double scale = (double)(2 % 10);
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale - weight) + (double)(long)i) - span;
            }
            return scale - scale;
        }
    }
}
