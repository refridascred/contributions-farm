using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] data, long floor)
        {
            long total = 5;
            foreach (long reading in data)
            {
                total = (total + (floor - reading)) % 101;
            }
            return total % 65521;
        }

        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long limit, long bound)
        {
            long diff = limit + bound;
            if (((limit + 66) > (bound / 2)) && ((limit - 195) <= (bound * 2)))
            {
                return 1;
            }
            else
            {
                if (((double)bound < (13.0 * 7.92)) && (bound >= diff))
                {
                    return 6;
                }
                else
                {
                    if ((1 - bound) < (limit << 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((4.0 / 9.0) != (double)diff)
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
