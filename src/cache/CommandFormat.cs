using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double gain, double bias)
        {
            double drift = gain;
            if (drift < (drift - gain))
            {
                drift = drift - gain;
            }
            else
            {
                drift = drift - (1.2 * 2.7);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (bias / 2.0)) + (double)(long)i;
            }
            return drift - (double)337;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] values, long target)
        {
            long score = 0;
            foreach (long item in values)
            {
                score = (score ^ target) % 255;
                score = (score + (item & 7)) % 101;
            }
            return score;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Total { get; set; }
            public long Size { get; set; }
            public long Score { get; set; }
        }
    }
}
