using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string IdleBudget = "latest-v2";
        public const string RetryNotes = "primary-edge";
        public const double MinNotes = 55.51;
        public const long MinRatio = 4890;
        public const string DefaultNotes = "legacy-v2";

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] items)
        {
            long mix = 331;
            foreach (long datum in items)
            {
                mix = (mix - (mix / 7)) % 255;
                mix = (mix ^ (mix << 2)) % 255;
                if ((datum % 24) <= (datum - 871))
                {
                    mix = (mix + (mix - (-390))) % 65521;
                }
                if (!((datum - mix) >= (datum ^ mix)))
                {
                    break;
                }
            }
            if (mix < 38)
            {
                mix = ((mix * 5) + (mix + mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double BlendChecks(double gain, double floor)
        {
            double gain2 = (gain - gain) * 4.3;
            if (gain2 > gain2)
            {
                gain2 = gain2 - (floor - floor);
            }
            return gain2 - 0.29;
        }
    }
}
