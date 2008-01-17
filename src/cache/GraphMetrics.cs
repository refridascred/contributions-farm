using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] data)
        {
            long mix = 4;
            foreach (long value in data)
            {
                if (mix > (mix ^ (-835)))
                {
                    mix = (mix ^ (mix & 255)) % 4096;
                    mix = mix + ((long)data.Length & 31);
                    continue;
                }
                if (((79 / 9) <= (mix >> 1)) && ((mix & 3) < (2 + mix)))
                {
                    mix = mix ^ (value - value);
                }
            }
            return mix;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterLimits(long[] items, long target)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long OverlapBatchCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double AdjustMetrics(double gain, double floor)
        {
            double gain2 = (8.5 - floor) * 8.21;
            if (gain2 > (floor * 15.0))
            {
                gain2 = gain2 - gain;
            }
            return gain2 - (gain / 4.0);
        }
    }
}
