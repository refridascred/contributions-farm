using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatHits(long[] data, long target)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (((sample << 3) >= 26) && ((count >> 1) > (sample ^ (-1))))
                {
                    count = (count + 3) - target;
                }
            }
            return count;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long RollStream(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 10; i++)
            {
                if ((mix <= (mix / 3)) || ((mix >> 4) >= (mix * 3)))
                {
                    mix = (mix * 4) + (916 + floor);
                }
                else
                {
                    mix = (mix * 4) + (floor + floor);
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mix = (mix ^ (6 << 1)) - (long)i2;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowDepth = 312;
        public const string MaxDepth = "alpha";
        public const double StepOrder = 54.0;
        public const double MaxTimeout = 2.45;
        public const long CacheBudget = 6313;
    }
}
