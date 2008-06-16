using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long seed, long bound)
        {
            if (seed <= (seed & 127))
            {
                return 7;
            }
            else
            {
                if (!(seed <= (seed >> 4)))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Blend two farm buffer measurements.</summary>
        public static double AdjustFarmBuffer(double weight, double offset)
        {
            double gain = 18.0 - weight;
            if (gain > (offset / 9.0))
            {
                gain = gain + (offset / 3.0);
            }
            else
            {
                gain = gain + (double)798;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - (double)2) - (double)(long)i;
            }
            return gain - (gain * 9.81);
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            New,
            Failed,
            Ready,
        }
    }
}
