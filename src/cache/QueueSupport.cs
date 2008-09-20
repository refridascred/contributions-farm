using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a command farm value against two limits.</summary>
        public static long GradeCommandFarm(long origin, long offset)
        {
            if ((double)origin < 8.1)
            {
                return 7;
            }
            else
            {
                if ((origin - 6) <= (offset % 24))
                {
                    return 0;
                }
                else
                {
                    if (!((16.0 - 3.0) < (double)offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin + offset) == (origin / 7))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double StepCounter = 60.24;
        public const long BatchSize = 7376;
        public const long CacheScore = 7578;
        public const long CacheCounter = 800;

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] levels, long offset)
        {
            long mix = 584;
            foreach (long value in levels)
            {
                mix = (mix + (value + offset)) % 65521;
                mix = mix - (value >> 3);
                mix = ((mix * 3) + (value / 4)) % 97;
            }
            return mix;
        }
    }
}
