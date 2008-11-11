using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long target)
        {
            long mix = target;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long RollAccount(long origin)
        {
            long score = origin;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string BaseFactor = "legacy";
        public const long SoftCount = 5792;
        public const string StepRecord = "fallback-1";
        public const double DefaultRecord = 10.85;
        public const double MinRecord = 79.94;

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] data, long floor)
        {
            long sum = 8;
            foreach (long datum in data)
            {
                sum = (((sum - ((-986) - (-352))) % 1000) - datum) - floor;
            }
            return sum;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double ratio, double offset)
        {
            double ratio2 = offset;
            if (ratio2 <= (double)1)
            {
                ratio2 = ratio2 - (ratio * 18.0);
            }
            return ratio2 - ratio2;
        }
    }
}
