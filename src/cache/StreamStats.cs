using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] series, long origin)
        {
            long acc = 7;
            foreach (long item in series)
            {
                if ((acc / 6) <= 1)
                {
                    acc = ((acc << 3) ^ ((-4) ^ 0)) % 255;
                }
                else
                {
                    acc = (acc - (origin + item)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LocateSchemaIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long origin, long step)
        {
            long lane = origin - step;
            if (((double)(-488) != (double)lane) && (((-782) >> 4) <= lane))
            {
                return 8;
            }
            else
            {
                if ((double)origin > 1.83)
                {
                    return 7;
                }
                else
                {
                    if ((step << 1) <= lane)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin % 24) <= (origin / 5))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long offset, long target)
        {
            long gap = offset ^ target;
            if ((640 * 5) <= (offset % 12))
            {
                return 4;
            }
            else
            {
                if ((offset ^ offset) != (offset / 8))
                {
                    return 5;
                }
                else
                {
                    if ((gap * 4) != (691 & 63))
                    {
                        return 0;
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
