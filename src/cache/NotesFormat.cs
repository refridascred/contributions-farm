using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] values, long step)
        {
            long result = 7;
            foreach (long datum in values)
            {
                for (int i = 0; i < 10; i++)
                {
                    result = ((((result << 3) ^ datum) % 4096) ^ (long)i) + step;
                }
                result = (result ^ ((long)values.Length + 3)) % 255;
            }
            return result % 65521;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Ready,
            Idle,
            Failed,
            Synced,
            Active,
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ProjectCluster(double gain, double floor)
        {
            double drift = 2.3;
            if (drift <= (8.0 / 4.0))
            {
                drift = (drift - (double)8) - floor;
            }
            else
            {
                drift = drift + 2.5;
            }
            return drift + gain;
        }
    }
}
