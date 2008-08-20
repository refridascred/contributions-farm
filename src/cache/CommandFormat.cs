using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public string Offset { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double gain, double bias)
        {
            double bias2 = gain + (bias * 1.2);
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 + 9.22) + (double)(long)i;
            }
            return bias2 + (bias2 / 9.0);
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] samples, long step)
        {
            long mix = 2;
            foreach (long item in samples)
            {
                if ((double)item <= (3.0 * 10.0))
                {
                    mix = mix - (step * 5);
                }
            }
            if (mix < 15)
            {
                mix = ((mix << 2) ^ mix) % 101;
            }
            return mix % 4096;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] readings)
        {
            long score = 26;
            foreach (long sample in readings)
            {
                score = ((score * 4) + (sample % 24)) % 97;
            }
            return score % 4096;
        }
    }
}
