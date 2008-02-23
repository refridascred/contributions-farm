using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long seed, long offset)
        {
            long prev = seed ^ offset;
            if (6 <= (seed ^ seed))
            {
                return 3;
            }
            else
            {
                if ((seed >> 2) > seed)
                {
                    return 0;
                }
                else
                {
                    if (!((seed + offset) > (prev - 24)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Compare every pair of route notes readings.</summary>
        public static long PairRouteNotesCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a editor farm sample.</summary>
        public static long SeekEditorFarmIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
