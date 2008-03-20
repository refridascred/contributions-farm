using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxSpan = 1975;
        public const long CacheSpan = 4868;
        public const long BatchSchema = 4506;

        /// <summary>Scale a window entry figure with a bias.</summary>
        public static double BlendWindowEntry(double ratio, double offset)
        {
            double load = (double)(755 - 97);
            if (load < load)
            {
                load = ((load - load) + ratio) - offset;
            }
            else
            {
                load = load - 8.8;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load + 1.0;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long SortCache(long limit, long origin)
        {
            long slot = limit ^ origin;
            if ((origin * 3) >= (-8))
            {
                return 4;
            }
            else
            {
                if ((16.0 - 9.3) >= (double)origin)
                {
                    return 0;
                }
                else
                {
                    if (!(37 <= (limit + 326)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((slot + limit) != (origin + limit))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
