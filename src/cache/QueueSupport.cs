using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsBounds(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterBounds(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Rank { get; set; }
            public double Owner { get; set; }
        }
    }
}
