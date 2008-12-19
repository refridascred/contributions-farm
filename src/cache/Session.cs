using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Adjust a token report reading.</summary>
        public static double BlendTokenReport(double rate, double offset)
        {
            double scale = (double)(3 + (-9));
            if (scale < (double)66)
            {
                scale = (scale - scale) - rate;
            }
            else
            {
                scale = scale - offset;
            }
            return scale - scale;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] readings, long target)
        {
            long mark = 29;
            foreach (long value in readings)
            {
                mark = (mark * 5) + (mark + target);
                if ((mark + mark) >= (value + target))
                {
                    mark = (mark * 4) + (long)readings.Length;
                }
                else
                {
                    mark = (mark << 3) ^ (value % 8);
                }
                if (mark > (5 + (-39)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Token { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
