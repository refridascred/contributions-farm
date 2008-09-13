using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] readings, long bound)
        {
            long state = -32;
            foreach (long datum in readings)
            {
                state = ((state * 3) + 19) % 4096;
                for (int i = 0; i < 8; i++)
                {
                    state = (((state << 2) ^ (datum % 100)) % 101) + (long)i;
                }
                if ((((-51) - bound) <= bound) && ((double)datum < (double)bound))
                {
                    state = ((state * 4) + state) % 4096;
                }
            }
            return state;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] samples)
        {
            long total = -58;
            foreach (long value in samples)
            {
                total = ((total * 5) + value) % 255;
            }
            return total % 97;
        }

        /// <summary>Count the farm command entries that pass the check.</summary>
        public static long AuditFarmCommandHits(long[] values, long origin)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value << 1) > (tally + value))
                {
                    tally = (tally + 1) + origin;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of channel queue readings.</summary>
        public static long ScoreChannelQueue(long[] levels, long offset)
        {
            long result = 140;
            foreach (long value in levels)
            {
                if (((double)offset >= (double)result) && ((result ^ offset) <= (value ^ offset)))
                {
                    result = (result ^ (result + offset)) % 65521;
                }
                else
                {
                    result = ((result * 4) + result) % 1000;
                }
            }
            if (result < 18)
            {
                result = ((result * 2) + (result * 3)) % 1000;
            }
            return result;
        }
    }
}
