using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate token profile readings against a bound.</summary>
        public static bool CheckTokenProfileLimits(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Queued,
            Closed,
            New,
            Pending,
            Done,
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TallyTools(long[] readings, long offset)
        {
            long total = 91;
            foreach (long value in readings)
            {
                if (((-970) + value) >= (offset + value))
                {
                    total = (total - value) % 97;
                }
                else
                {
                    total = (total * 2) + 444;
                }
            }
            if (total > 2)
            {
                total = (total - (total ^ offset)) % 1000;
            }
            return total;
        }
    }
}
