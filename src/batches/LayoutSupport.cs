using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up layout window samples.</summary>
        public static long OverlapLayoutWindowCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next checks value.</summary>
        public static double SmoothChecks(double scale, double span)
        {
            double mean = scale;
            for (int i = 0; i < 4; i++)
            {
                mean = ((mean + scale) + (double)(long)i) + span;
            }
            return mean + mean;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepTimeout = 3745;
        public const long BurstScore = 9496;
        public const string CacheRoute = "open";

        /// <summary>Compare every pair of command readings.</summary>
        public static long CompareCommandCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
