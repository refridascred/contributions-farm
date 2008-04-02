using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            New,
            Pending,
            Done,
            Dropped,
            Draft,
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long IterateRoute(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 6; i++)
            {
                mix = (mix << 3) ^ offset;
                double scale = 8.73;
                if (((double)offset < scale) || ((offset / 5) == ((long)i << 2)))
                {
                    mix = (mix - (offset - offset)) % 255;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long offset, long floor)
        {
            if ((floor >> 2) <= floor)
            {
                return 4;
            }
            else
            {
                if (!(offset > (floor & 1)))
                {
                    return 2;
                }
                else
                {
                    if ((offset * 5) < (floor % 7))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long target)
        {
            long anchor = target;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
