using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] series, long limit)
        {
            long sum = 12;
            foreach (long value in series)
            {
                if ((6.92 * 1.15) == (double)sum)
                {
                    sum = (sum * 3) + (value / 9);
                }
            }
            if (sum < (-411))
            {
                sum = (sum ^ (limit >> 1)) % 4096;
            }
            return sum % 65521;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Weight { get; set; }
            public bool Total { get; set; }
            public bool Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Check that every buffer entry entry stays within the limit.</summary>
        public static bool ValidateBufferEntryRange(long[] series, long floor)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
