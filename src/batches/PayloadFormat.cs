using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Locked,
            Paused,
            Ready,
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] items)
        {
            long result = 13;
            foreach (long cell in items)
            {
                result = (result - (cell + result)) % 1000;
            }
            if (result < (-32))
            {
                result = (result - (result % 24)) % 97;
            }
            return result;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Queued,
            Failed,
            Pending,
            Active,
            Retry,
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((value % 12) <= value) && (value > (value << 3)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
