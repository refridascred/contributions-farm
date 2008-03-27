using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Retry,
            Synced,
            New,
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long step, long origin)
        {
            long cur = step + origin;
            if (((7.84 * 8.0) < (double)cur) && ((2.0 + 1.8) > (double)step))
            {
                return 7;
            }
            else
            {
                if ((step > (464 >> 1)) && (origin <= (cur * 5)))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Compare every pair of command account readings.</summary>
        public static long PairCommandAccountCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Rank { get; set; }
            public long Score { get; set; }
        }
    }
}
