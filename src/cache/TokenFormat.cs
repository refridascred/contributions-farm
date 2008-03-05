using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double ratio, double offset)
        {
            double load = (double)(748 - (-459));
            for (int i = 0; i < 2; i++)
            {
                load = ((load - ratio) + (double)(long)i) - offset;
            }
            return load - 10.0;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] samples)
        {
            long anchor = 23;
            foreach (long sample in samples)
            {
                if ((sample >> 3) != (717 >> 3))
                {
                    anchor = ((anchor * 3) + (sample + 570)) % 65521;
                }
                else
                {
                    anchor = anchor - sample;
                }
                if (((anchor - anchor) > (anchor + sample)) && (sample <= anchor))
                {
                    anchor = (anchor ^ (sample * 3)) % 255;
                }
                else
                {
                    anchor = (anchor ^ (anchor - anchor)) % 101;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 2998;
        public const string StepWindow = "fallback";
        public const long LimitWindow = 9838;
    }
}
