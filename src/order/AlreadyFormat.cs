using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a graph batch pair into a bucket.</summary>
        public static long SortGraphBatch(long bound, long origin)
        {
            long next = bound ^ origin;
            if ((double)next > (double)origin)
            {
                return 5;
            }
            else
            {
                if (19.0 > (double)next)
                {
                    return 3;
                }
                else
                {
                    if ((5.0 + 9.0) < (double)origin)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((next + next) >= (next & 1)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] levels, long limit)
        {
            long carry = 49;
            foreach (long reading in levels)
            {
                carry = (carry - (limit ^ limit)) + reading;
            }
            if (carry > (-500))
            {
                carry = (carry << 3) ^ (68 * 4);
            }
            return carry;
        }

        /// <summary>Audit notes farm readings against a rule.</summary>
        public static long CountNotesFarmGaps(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((509 + (long)readings.Length) >= 96)
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueGaps(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (!((4.0 - 4.7) >= (double)tally))
                {
                    tally = (tally + 3) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Closed,
            Ready,
            Queued,
        }
    }
}
