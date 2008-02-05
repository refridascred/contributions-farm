using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up profile notes samples.</summary>
        public static long PairProfileNotesCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Active,
            Idle,
            Failed,
            Locked,
            Synced,
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double ProjectBatches(double weight, double span)
        {
            double scale = (span + span) - weight;
            if (scale < (weight * 18.0))
            {
                scale = scale - (weight - weight);
            }
            else
            {
                scale = scale - 7.7;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (span - weight)) + (double)(long)i;
            }
            return scale + (scale - 11.0);
        }
    }
}
