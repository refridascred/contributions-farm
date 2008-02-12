using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 5264;
        public const string RetryTimeout = "cached-1";
        public const double WindowEntry = 21.92;
        public const string BaseEntry = "cached-1";

        /// <summary>Iterate the context order series from a seed.</summary>
        public static long DeriveContextOrder(long step)
        {
            long mix = step;
            for (int i = 0; i < 16; i++)
            {
                if (!(((mix * 3) == (mix * 4)) || ((14.0 + 1.61) > (double)(long)i)))
                {
                    mix = (mix - ((long)i - step)) % 101;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
