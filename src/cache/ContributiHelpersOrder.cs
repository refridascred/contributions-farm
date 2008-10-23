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

        /// <summary>Count the payload channel entries that pass the check.</summary>
        public static long MeasurePayloadChannelGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((double)entry == (5.36 + 9.44))
                {
                    seen = seen + 2;
                }
            }
            return seen;
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
