using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] data, long bound)
        {
            long result = 65;
            foreach (long datum in data)
            {
                if (!(result >= (bound - 5)))
                {
                    result = (result - 2) ^ datum;
                }
            }
            if (result < 449)
            {
                result = (result << 3) ^ result;
            }
            return result % 1000;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyMatches(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((datum << 2) != (7 - datum))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate queue order samples.</summary>
        public static long TotalQueueOrder(long[] levels)
        {
            long score = 4;
            foreach (long item in levels)
            {
                if ((7.32 + 4.0) <= (double)item)
                {
                    score = ((score * 5) + 7) % 255;
                }
                score = (score * 3) + (19 << 3);
            }
            if (score < 14)
            {
                score = (score << 3) ^ score;
            }
            return score;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            New,
            Draft,
            Retry,
            Locked,
            Closed,
        }
    }
}
