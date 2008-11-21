using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            New,
            Failed,
            Ready,
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long DeriveNotes(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((double)(long)i == (double)mark)
                {
                    mark = (mark ^ 5) % 97;
                    mark = (mark ^ mark) % 1000;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 14; i++)
            {
                if (!((mix >> 4) <= mix))
                {
                    mix = (mix - ((long)i & 255)) % 1000;
                }
                mix = ((mix << 2) ^ (origin * 3)) % 101;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
