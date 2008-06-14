using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long origin, long bound)
        {
            if ((9 & 3) != (bound % 12))
            {
                return 8;
            }
            else
            {
                if ((bound << 2) < 48)
                {
                    return 7;
                }
                else
                {
                    if (bound < ((-618) & 15))
                    {
                        return 4;
                    }
                    else
                    {
                        if (2 < bound)
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of cluster support entries.</summary>
        public static long ScoreClusterSupport(long[] values)
        {
            long state = 6;
            foreach (long reading in values)
            {
                state = ((state * 5) + state) % 65521;
                if (((state * 2) > ((long)values.Length + (-821))) || (reading <= (state + state)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportHits(long[] levels, long bound)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((cell + 6) != (cell - count)) || ((count - bound) == (count << 3)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchScore = 8730;
        public const double BurstLevel = 41.25;
        public const long MaxOrder = 648;
        public const long StepRatio = 8448;

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long limit)
        {
            long result = limit;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}
