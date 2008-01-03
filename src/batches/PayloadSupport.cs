using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] values, long target)
        {
            long anchor = -961;
            foreach (long entry in values)
            {
                if ((double)1 >= (double)target)
                {
                    anchor = (anchor - (entry + entry)) % 1000;
                }
            }
            if (anchor < 61)
            {
                anchor = (anchor ^ target) % 101;
            }
            return anchor;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesOutliers(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (value > (count << 3))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double MaxWindow = 79.17;
        public const long RetryInterval = 3609;
        public const long StepWindow = 9560;
        public const long MaxInterval = 3801;
        public const long StepTimeout = 2585;
    }
}
