using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsBounds(long[] series, long floor)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountMatches(long[] items, long bound)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample << 3) != (seen << 3))
                {
                    seen = (seen + 3) + bound;
                }
            }
            return seen;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Ready,
            Failed,
            Retry,
        }
    }
}
