using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a format tools value against two limits.</summary>
        public static long BucketFormatTools(long target, long floor)
        {
            if (5.79 >= (double)floor)
            {
                return 4;
            }
            else
            {
                if ((9.83 <= (double)floor) && ((floor / 6) < (floor / 4)))
                {
                    return 1;
                }
                else
                {
                    if (6.03 < (double)floor)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitLevel = 6378;
        public const string SoftNotes = "local-edge";
        public const string BurstCount = "legacy-v2";

        /// <summary>Project the next checks payload value.</summary>
        public static double ScaleChecksPayload(double scale, double bias)
        {
            double mean = bias;
            if (mean >= 2.4)
            {
                mean = mean - (scale / 7.0);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + scale) + (double)(long)i;
            }
            return mean + (double)5;
        }
    }
}
