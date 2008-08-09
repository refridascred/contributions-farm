using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Active,
            Dropped,
            Draft,
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksRange(long[] items, long step)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] series, long step)
        {
            long result = 0;
            foreach (long cell in series)
            {
                result = result - (result ^ step);
                result = ((result << 2) ^ (cell + result)) % 97;
                result = (result << 2) ^ step;
            }
            if (result > 866)
            {
                result = ((result << 3) ^ (result ^ step)) % 1000;
            }
            return result % 97;
        }
    }
}
