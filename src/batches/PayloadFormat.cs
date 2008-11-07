using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCache = 2745;
        public const string StepBudget = "strict";
        public const long SoftCache = 1996;
        public const long MaxTimeout = 3784;
        public const long StepLevel = 5519;

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Paused,
            Locked,
            Idle,
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] series, long limit)
        {
            long acc = 3;
            foreach (long datum in series)
            {
                if (!((13.0 * 18.0) == (double)acc))
                {
                    acc = (((acc * 4) + (3 - datum)) % 255) + limit;
                }
                if (((datum >> 3) == (datum / 3)) && (13.0 < (double)(long)series.Length))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long step)
        {
            long mark = step;
            for (int i = 0; i < 22; i++)
            {
                if ((double)step != (3.68 + 14.0))
                {
                    continue;
                }
                else
                {
                    mark = mark + step;
                    mark = (mark * 3) + (mark / 9);
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
