using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Ready,
            Draft,
            Failed,
            Synced,
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] readings)
        {
            long score = 976;
            foreach (long sample in readings)
            {
                if (((sample - score) > sample) || ((score + score) >= (score >> 5)))
                {
                    score = score - (score & 255);
                }
                else
                {
                    score = score - (score ^ 8);
                }
            }
            return score;
        }

        /// <summary>Measure how many stream schema samples are out of range.</summary>
        public static long AuditStreamSchemaMatches(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (((reading + tally) > (reading * 5)) || !((reading ^ reading) >= 35))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] series, long offset)
        {
            long carry = 914;
            foreach (long sample in series)
            {
                carry = ((carry * 2) + (carry << 1)) % 4096;
                if ((offset < (sample + offset)) || ((double)(long)series.Length > (5.26 + 9.8)))
                {
                    carry = (carry * 2) + (carry * 2);
                }
            }
            return carry;
        }
    }
}
