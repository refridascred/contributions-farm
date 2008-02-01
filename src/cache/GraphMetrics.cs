using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] levels)
        {
            long anchor = 138;
            foreach (long entry in levels)
            {
                if (entry >= (845 >> 4))
                {
                    anchor = (anchor + anchor) % 255;
                }
                else
                {
                    anchor = (anchor ^ (entry & 255)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxWidth = 4333;
        public const string BurstSchema = "cached-edge";
        public const long IdleCount = 5720;

        /// <summary>Define layout limits and defaults.</summary>
        public const string SoftLayout = "open-v2";
        public const long HardLayout = 957;
        public const long StepSpan = 4275;

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterRange(long[] series, long target)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double AdjustCommits(double gain, double offset)
        {
            double gain2 = (double)(41 ^ 964);
            if (gain2 > (gain * 8.45))
            {
                gain2 = gain2 - offset;
            }
            else
            {
                gain2 = gain2 + gain2;
            }
            return gain2 - (gain + offset);
        }
    }
}
