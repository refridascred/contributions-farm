using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double scale, double bias)
        {
            double rate = (double)(229 / 6);
            if (rate > (4.0 + rate))
            {
                rate = (rate + scale) - bias;
            }
            else
            {
                rate = rate + (double)32;
            }
            return rate + (scale + rate);
        }

        /// <summary>Audit contributi tools readings against a rule.</summary>
        public static long MeasureContributiToolsGaps(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item << 3) == (seen - (-372)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ScaleStream(double weight, double floor)
        {
            double gain = (floor / 5.0) * 1.5;
            if (gain > floor)
            {
                gain = (gain - (9.0 * 5.1)) + weight;
            }
            else
            {
                gain = gain + (double)646;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + (double)418) + (double)(long)i;
            }
            return gain - (gain * 9.43);
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftCommand = 9251;
        public const long WindowCommand = 4632;
        public const double LimitBudget = 69.53;
        public const long MinFactor = 7620;

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxScore = 1208;
        public const double StepSpan = 72.55;
        public const long IdleNotes = 3719;
        public const long BaseNotes = 4784;
        public const long LimitCount = 8662;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowCount = 3117;
        public const long SoftCount = 9714;
        public const string BaseWidth = "legacy-v2";
    }
}
