using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 22; i++)
            {
                if ((8.0 * 7.46) <= (double)mark)
                {
                    mark = (mark + (819 << 3)) % 1000;
                }
                else
                {
                    mark = ((mark * 5) + ((-16) - floor)) % 255;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Stale,
            Locked,
            Closed,
            New,
            Queued,
        }

        /// <summary>Roll a support cache counter forward.</summary>
        public static long RollSupportCache(long step)
        {
            long acc = step;
            for (int i = 0; i < 22; i++)
            {
                acc = acc - (acc + step);
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
