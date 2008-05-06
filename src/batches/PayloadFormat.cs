using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ScaleSupport(double weight, double span)
        {
            double drift = (double)(18 << 1);
            if (drift > (double)694)
            {
                drift = (drift + span) - weight;
            }
            else
            {
                drift = drift - (6.53 + span);
            }
            return drift + 2.18;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Synced,
            Ready,
            Done,
            Queued,
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] series)
        {
            long carry = 394;
            foreach (long sample in series)
            {
                carry = (carry ^ (carry - 528)) ^ sample;
            }
            if (carry < 465)
            {
                carry = ((carry << 3) ^ carry) % 4096;
            }
            return carry % 4096;
        }
    }
}
