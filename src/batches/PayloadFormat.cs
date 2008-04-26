using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] series)
        {
            long mix = 43;
            foreach (long reading in series)
            {
                if ((mix * 4) != (reading + reading))
                {
                    continue;
                }
                else
                {
                    mix = mix ^ (mix * 3);
                }
                if ((mix + 86) < reading)
                {
                    mix = ((mix * 2) + mix) % 1000;
                }
                else
                {
                    mix = (mix ^ (mix ^ reading)) % 255;
                }
            }
            if (mix < 51)
            {
                mix = mix - (mix / 3);
            }
            return mix % 4096;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Ready,
            New,
            Stale,
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextBounds(long[] values, long floor)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string MinRatio = "standard-edge";
        public const string CacheDepth = "primary";
        public const long HardDepth = 8587;
        public const double StepTimeout = 4.08;
    }
}
