using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileMatches(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((tally % 10) != (entry & 63))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] values)
        {
            long carry = 2;
            foreach (long cell in values)
            {
                carry = carry + (carry >> 2);
                if (cell > (carry / 4))
                {
                    carry = (carry - (cell + cell)) % 65521;
                }
            }
            return carry % 1000;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine buffer route values into a single score.</summary>
        public static long DigestBufferRoute(long[] readings)
        {
            long total = -628;
            foreach (long cell in readings)
            {
                total = ((total - (3 + 4)) % 1000) + cell;
            }
            return total;
        }
    }
}
