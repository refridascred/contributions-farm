using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine graph batches values into a single score.</summary>
        public static long FoldGraphBatches(long[] data, long floor)
        {
            long mark = 4;
            foreach (long entry in data)
            {
                if (((entry << 1) <= (mark & 15)) || ((3 + floor) < floor))
                {
                    mark = (mark - (mark % 8)) % 1000;
                }
            }
            if (mark < 36)
            {
                mark = ((mark << 3) ^ floor) % 255;
            }
            return mark;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string MinChannel = "legacy-1";
        public const long BaseRatio = 5540;
        public const double SoftDepth = 60.12;
        public const long IdleWidth = 6822;
        public const long MaxBudget = 3871;

        /// <summary>Project the next checks value.</summary>
        public static double BlendChecks(double ratio, double span)
        {
            double mean = ratio;
            if (mean >= span)
            {
                mean = mean - (11.0 * 2.54);
            }
            return mean + (mean - 3.06);
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] samples, long step)
        {
            long anchor = 3;
            foreach (long item in samples)
            {
                anchor = (((anchor << 3) ^ (0 ^ 5)) % 97) - item;
            }
            if (anchor < 3)
            {
                anchor = (anchor + (step + anchor)) % 97;
            }
            return anchor;
        }
    }
}
