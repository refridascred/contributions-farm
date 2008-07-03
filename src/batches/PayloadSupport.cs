using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Queued,
            Active,
            Pending,
            Paused,
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyMatches(long[] items, long target)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((sample - tally) > (target / 7))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] levels)
        {
            long mark = 0;
            foreach (long value in levels)
            {
                if ((value & 3) >= mark)
                {
                    mark = (mark << 3) ^ (value >> 5);
                }
            }
            return mark % 97;
        }
    }
}
