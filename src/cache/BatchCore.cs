using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Failed,
            Ready,
            Paused,
            Dropped,
            Draft,
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public bool Rank { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Roll a notes contributi counter forward.</summary>
        public static long SeriesNotesContributi(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 12; i++)
            {
                if (!(carry < (limit / 4)))
                {
                    carry = (carry ^ (carry * 4)) % 65521;
                }
                carry = (carry + ((long)i + limit)) % 101;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((6.5 / 4.0) >= (double)tally)
                {
                    tally = ((tally + 1) + entry) + step;
                }
            }
            return tally;
        }
    }
}
