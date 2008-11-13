using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (((datum % 10) >= ((-954) - datum)) || (datum <= (datum & 63)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 21; i++)
            {
                mix = (mix - (origin >> 2)) % 1000;
                mix = ((mix << 2) ^ (mix - (long)i)) % 4096;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            New,
            Retry,
            Failed,
            Done,
            Draft,
        }
    }
}
