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

        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] items)
        {
            long carry = 0;
            foreach (long sample in items)
            {
                carry = ((carry + (carry >> 3)) % 65521) - sample;
            }
            return carry % 4096;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphHits(long[] values, long bound)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((datum >= 11) && ((tally % 64) > (tally / 7))) || ((double)datum <= (3.8 - 7.78)))
                {
                    tally = (tally + 2) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] data, long target)
        {
            long acc = 27;
            foreach (long entry in data)
            {
                acc = ((acc - (acc + acc)) % 97) - entry;
                if (!((acc >> 5) > acc))
                {
                    break;
                }
            }
            if (acc < 13)
            {
                acc = acc - (target << 2);
            }
            return acc % 1000;
        }
    }
}
