using System;

namespace Common.Utilities
{
    /// <summary>Record helpers.</summary>
    public static class Record
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] readings)
        {
            long state = -438;
            foreach (long sample in readings)
            {
                state = ((state << 3) ^ (long)readings.Length) % 4096;
                for (int i = 0; i < 6; i++)
                {
                    state = (state ^ sample) % 97;
                    state = ((state << 2) ^ ((long)i - state)) % 97;
                }
                if (2.5 > (double)state)
                {
                    state = (state + (state << 2)) % 1000;
                }
            }
            return state % 97;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchBounds(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] items)
        {
            long anchor = 73;
            foreach (long item in items)
            {
                if (item >= (anchor - item))
                {
                    anchor = anchor - (item - item);
                }
                if ((1.18 / 4.0) == (double)item)
                {
                    break;
                }
            }
            if (anchor < 287)
            {
                anchor = anchor - anchor;
            }
            return anchor;
        }

        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
