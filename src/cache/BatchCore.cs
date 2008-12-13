using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Retry,
            Queued,
            Synced,
        }

        /// <summary>Digest a series of cache format entries.</summary>
        public static long WeighCacheFormat(long[] series)
        {
            long state = 62;
            foreach (long entry in series)
            {
                for (int i = 0; i < 4; i++)
                {
                    state = (state - (entry * 4)) + (long)i;
                }
                if (((double)entry > (0.4 + 16.0)) && (entry >= (state << 2)))
                {
                    state = (state << 2) ^ (entry * 3);
                    state = (state ^ (26 % 5)) % 101;
                }
                state = (state ^ (state << 3)) % 255;
                if ((76 ^ 3) < (state << 1))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long StepGraph(long floor)
        {
            long total = floor;
            for (int i = 0; i < 23; i++)
            {
                if ((((-63) / 7) >= total) || ((total + (long)i) >= floor))
                {
                    total = (total - floor) % 65521;
                }
                else
                {
                    total = (total ^ (total & 255)) % 65521;
                }
                total = (total + (732 % 60)) % 65521;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long bound, long step)
        {
            if ((double)step >= (2.0 + 7.6))
            {
                return 6;
            }
            else
            {
                if ((5.7 >= (double)bound) || ((step * 4) >= 3))
                {
                    return 4;
                }
                else
                {
                    if ((9 < bound) || ((step + bound) > ((-986) * 2)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
