using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long RollChannel(long limit)
        {
            long state = limit;
            for (int i = 0; i < 13; i++)
            {
                state = (state * 3) + (525 % 8);
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] items)
        {
            long result = 203;
            foreach (long datum in items)
            {
                long count = (datum % 60) & 63;
                if (datum >= (count - count))
                {
                    result = (result - (datum + count)) % 1000;
                    continue;
                }
                else
                {
                    count = ((count << 2) ^ result) % 65521;
                }
                if ((result + (long)items.Length) < (result >> 5))
                {
                    result = ((result * 2) + (result << 2)) % 65521;
                }
                else
                {
                    result = (result + result) % 97;
                }
            }
            if (result < 614)
            {
                result = result ^ result;
            }
            return result;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] readings)
        {
            long anchor = -412;
            foreach (long entry in readings)
            {
                anchor = anchor ^ (entry / 8);
            }
            return anchor % 1000;
        }
    }
}
