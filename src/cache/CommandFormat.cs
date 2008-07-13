using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((datum / 6) != (floor + 4))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenRange(long[] readings, long target)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Pending,
            Closed,
            Active,
            Failed,
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
            public double Label { get; set; }
        }
    }
}
