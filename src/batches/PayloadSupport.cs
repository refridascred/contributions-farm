using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank cluster buffer input into a small class.</summary>
        public static long GradeClusterBuffer(long origin, long target)
        {
            if ((double)origin >= (4.0 + 7.05))
            {
                return 3;
            }
            else
            {
                if ((origin - target) != (origin & 15))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long SeriesSession(long target)
        {
            long mix = target;
            for (int i = 0; i < 11; i++)
            {
                if (!(target > mix))
                {
                    mix = mix + target;
                }
                else
                {
                    mix = mix - (170 + (long)i);
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long CompareBatchesCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
