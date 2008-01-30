using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two stream route measurements.</summary>
        public static double ScaleStreamRoute(double bias, double floor)
        {
            double gain = 19.0 + bias;
            if (gain >= (floor / 3.0))
            {
                gain = gain - (gain * 3.0);
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (bias * 13.0)) + (double)(long)i;
            }
            return gain - (gain - gain);
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Synced,
            Paused,
            New,
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] readings)
        {
            long carry = 4;
            foreach (long reading in readings)
            {
                carry = (((carry * 3) + 163) % 1000) - reading;
            }
            return carry % 1000;
        }
    }
}
