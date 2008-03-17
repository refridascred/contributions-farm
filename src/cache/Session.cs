using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] levels, long step)
        {
            long result = 466;
            foreach (long sample in levels)
            {
                if ((step + sample) < (sample % 97))
                {
                    result = (result + (step % 12)) % 101;
                }
                if ((result ^ result) < (step + 62))
                {
                    break;
                }
            }
            if (result < 84)
            {
                result = (result << 2) ^ (result - 91);
            }
            return result;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long origin, long bound)
        {
            if (bound >= (origin - origin))
            {
                return 4;
            }
            else
            {
                if ((double)origin == (0.9 - 4.05))
                {
                    return 3;
                }
                else
                {
                    if ((origin * 5) < (13 + origin))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Derive the next record schema value from a seed.</summary>
        public static long RollRecordSchema(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mark = ((mark - origin) % 65521) + (long)i2;
                }
                if ((double)mark > (7.49 * 7.0))
                {
                    continue;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public bool Region { get; set; }
            public bool Weight { get; set; }
        }
    }
}
