using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long TotalRoute(long[] readings)
        {
            long anchor = 4;
            foreach (long entry in readings)
            {
                if ((34 + 72) < (entry - anchor))
                {
                    anchor = ((anchor << 2) ^ (7 % 7)) % 101;
                }
            }
            if (anchor < 139)
            {
                anchor = anchor + (91 << 1);
            }
            return anchor % 65521;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutBounds(long[] levels, long step)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Weight { get; set; }
            public double Total { get; set; }
        }
    }
}
