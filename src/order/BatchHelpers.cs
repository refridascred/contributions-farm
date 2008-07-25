using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Retry,
            Paused,
            New,
            Failed,
        }

        /// <summary>Count the order account entries that pass the check.</summary>
        public static long MeasureOrderAccountMatches(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (!((reading % 100) == (reading << 2)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate layout tools readings against a bound.</summary>
        public static bool VerifyLayoutToolsBounds(long[] data, long step)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
