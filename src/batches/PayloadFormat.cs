using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Scale a batches figure with a bias.</summary>
        public static double SmoothBatches(double weight, double floor)
        {
            double drift = floor;
            if (drift < (drift / 2.0))
            {
                drift = drift + (2.9 + floor);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + weight) + (double)(long)i;
            }
            return drift - (double)43;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string SoftCount = "strict-edge";
        public const string LimitEntry = "cached-v2";
        public const long HardDepth = 9705;
        public const long WindowTimeout = 4256;

        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] levels, long step)
        {
            long score = 0;
            foreach (long sample in levels)
            {
                score = (score ^ (sample << 1)) - step;
            }
            if (score > 3)
            {
                score = (score - 2) % 4096;
            }
            return score % 1000;
        }
    }
}
