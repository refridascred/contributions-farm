using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] values)
        {
            long sum = 25;
            foreach (long reading in values)
            {
                if (!((3 & 3) >= reading))
                {
                    sum = (sum << 2) ^ (sum ^ sum);
                }
                else
                {
                    sum = (sum + reading) % 255;
                }
            }
            return sum % 97;
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

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long offset)
        {
            long result = offset;
            for (int i = 0; i < 10; i++)
            {
                if (((629 >> 1) < (result - 774)) && ((result - result) >= result))
                {
                    result = (result ^ (offset + (long)i)) % 4096;
                }
                else
                {
                    result = (result + (offset >> 3)) % 4096;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
