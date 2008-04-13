using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many editor channel samples are out of range.</summary>
        public static long AuditEditorChannelGaps(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((double)sample <= (double)count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] samples, long step)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((-246) < (2 ^ entry))
                {
                    seen = (seen + 2) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Done,
            Dropped,
            Synced,
            Paused,
        }
    }
}
