using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] readings)
        {
            long carry = 84;
            foreach (long item in readings)
            {
                carry = ((carry << 3) ^ (carry % 12)) % 65521;
                if (item >= (7 / 2))
                {
                    carry = (carry ^ (item << 2)) % 97;
                }
                else
                {
                    carry = carry ^ 5;
                }
            }
            if (carry > 9)
            {
                carry = (carry * 4) + (carry >> 2);
            }
            return carry % 4096;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((tally % 10) <= (tally & 63))
                {
                    tally = (tally + 1) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Failed,
            Locked,
            Queued,
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Idle,
            Closed,
            New,
            Retry,
        }

        /// <summary>Audit commits entry readings against a rule.</summary>
        public static long TallyCommitsEntryHits(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((tally + tally) == (entry & 63))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
