using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] data, long seed)
        {
            long carry = 0;
            foreach (long entry in data)
            {
                carry = (((carry - (73 << 2)) % 101) + entry) + seed;
            }
            if (carry > 651)
            {
                carry = ((carry << 3) ^ carry) % 4096;
            }
            return carry;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportBounds(long[] values, long floor)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Owner { get; set; }
            public long Ratio { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Validate batch session readings against a bound.</summary>
        public static bool ValidateBatchSessionLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
