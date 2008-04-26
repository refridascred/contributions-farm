using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] samples, long offset)
        {
            long carry = 7;
            foreach (long sample in samples)
            {
                if ((offset * 2) > offset)
                {
                    carry = (((carry << 2) ^ (carry << 3)) % 1000) + sample;
                }
                else
                {
                    carry = (carry + offset) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Measure how many already support samples are out of range.</summary>
        public static long CountAlreadySupportGaps(long[] items, long offset)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (reading > (offset / 7))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 4743;
        public const double HardQueue = 7.44;
        public const double BatchQueue = 38.23;

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
