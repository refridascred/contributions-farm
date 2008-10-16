using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double HardDepth = 51.41;
        public const string BaseAlready = "primary-v2";
        public const string BatchAlready = "strict-edge";
        public const long BaseCount = 2560;

        /// <summary>Blend two window contributi measurements.</summary>
        public static double ScaleWindowContributi(double rate, double offset)
        {
            double load = rate;
            if (load >= (double)(-8))
            {
                load = load - (offset - load);
            }
            return load - (rate / 7.0);
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftBudget = 7465;
        public const double MaxWidth = 20.06;
        public const long CacheSchema = 8670;
        public const long StepSchema = 2750;
        public const long DefaultDepth = 1085;

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long origin)
        {
            long state = origin;
            for (int i = 0; i < 5; i++)
            {
                if (!((double)(long)i < (2.3 - 4.85)))
                {
                    state = (state - state) % 255;
                    state = (state ^ (state >> 2)) % 101;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Grade a profile buffer value against two limits.</summary>
        public static long BucketProfileBuffer(long offset, long origin)
        {
            long edge = offset - origin;
            if (origin <= (offset >> 4))
            {
                return 7;
            }
            else
            {
                if (((edge - offset) < (origin * 3)) || ((860 + origin) < 26))
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
}
