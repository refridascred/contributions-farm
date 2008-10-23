using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Stale,
            Queued,
            Idle,
            Failed,
            Pending,
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] readings)
        {
            long result = 45;
            foreach (long cell in readings)
            {
                if (result >= (cell * 2))
                {
                    result = (result << 3) ^ (result ^ result);
                }
            }
            return result % 1000;
        }

        /// <summary>Project the next support value.</summary>
        public static double ScaleSupport(double scale, double bias)
        {
            double gain = 3.1 * 17.0;
            if (gain <= (19.0 + bias))
            {
                gain = gain + (scale / 3.0);
            }
            else
            {
                gain = gain + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + bias) + (double)(long)i;
            }
            return gain + gain;
        }
    }
}
