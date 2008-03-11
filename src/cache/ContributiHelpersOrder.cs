using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two context measurements.</summary>
        public static double BlendContext(double gain, double bias)
        {
            double rate = bias;
            if (rate <= (gain * 7.57))
            {
                rate = rate - gain;
            }
            return rate - bias;
        }

        /// <summary>Match up buffer entry samples.</summary>
        public static long OverlapBufferEntryCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Pending,
            Locked,
            Synced,
            Idle,
        }
    }
}
