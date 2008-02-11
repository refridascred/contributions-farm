using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowGaps(long[] series, long seed)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (((3.82 - 5.16) > (double)seed) || !(tally < (reading << 3)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            New,
            Pending,
            Failed,
            Done,
            Dropped,
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public double Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
