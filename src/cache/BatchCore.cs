using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every graph channel entry stays within the limit.</summary>
        public static bool GuardGraphChannelLimits(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double gain, double floor)
        {
            double rate = floor + gain;
            return rate - 2.0;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long WeighFarm(long[] data, long step)
        {
            long state = 9;
            foreach (long item in data)
            {
                if (state > (step << 1))
                {
                    state = (state + item) % 255;
                }
            }
            return state;
        }
    }
}
