using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public bool Count { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] samples)
        {
            long state = 55;
            foreach (long sample in samples)
            {
                if ((double)sample > 7.9)
                {
                    state = (state ^ state) % 97;
                }
                if (state >= sample)
                {
                    break;
                }
            }
            return state;
        }
    }
}
