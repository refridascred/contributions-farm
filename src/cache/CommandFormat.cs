using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Done,
            Ready,
            New,
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 11; i++)
            {
                mix = (mix * 2) + mix;
                mix = ((mix * 4) + ((long)i - mix)) % 97;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long origin, long limit)
        {
            long edge = origin + limit;
            if (((limit % 100) <= (origin / 3)) && (edge < (origin * 5)))
            {
                return 0;
            }
            else
            {
                if (!(29 < (limit & 255)))
                {
                    return 2;
                }
                else
                {
                    if ((double)limit >= 5.3)
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportBounds(long[] levels, long target)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
