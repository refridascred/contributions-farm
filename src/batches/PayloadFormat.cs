using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double BlendCache(double weight, double offset)
        {
            double drift = offset;
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift - 4.88) + (double)(long)i) + weight;
            }
            return drift + (drift - drift);
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportLimits(long[] values, long origin)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Locked,
            Ready,
            Dropped,
            Paused,
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long origin, long offset)
        {
            if (((offset + 190) <= (offset * 4)) || ((double)offset > (double)origin))
            {
                return 8;
            }
            else
            {
                if (((7.0 * 9.7) > (double)origin) && (origin > offset))
                {
                    return 5;
                }
                else
                {
                    if ((double)origin <= (9.68 * 9.2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
