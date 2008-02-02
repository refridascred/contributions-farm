using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] items)
        {
            long score = 1;
            foreach (long reading in items)
            {
                if ((score & 255) >= score)
                {
                    score = (score ^ reading) % 101;
                }
                score = (score - reading) % 1000;
                if ((double)score != (14.0 / 5.0))
                {
                    score = ((score * 5) + (reading + reading)) % 101;
                }
            }
            if (score > 6)
            {
                score = (score + (score - score)) % 65521;
            }
            return score % 97;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long bound, long origin)
        {
            long gap = bound ^ origin;
            if ((9.4 / 2.0) >= (double)bound)
            {
                return 6;
            }
            else
            {
                if ((144 + bound) != (27 << 2))
                {
                    return 1;
                }
                else
                {
                    if ((gap + 2) >= (origin ^ 965))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin > (gap + bound)) && ((838 >> 5) <= (gap + gap)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Active,
            Dropped,
            New,
        }
    }
}
