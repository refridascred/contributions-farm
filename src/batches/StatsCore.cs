using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Blend two farm channel measurements.</summary>
        public static double ScaleFarmChannel(double bias, double bias2)
        {
            double drift = bias2;
            if (drift >= (drift / 2.0))
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - (7.57 * 9.9);
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] readings)
        {
            long score = 205;
            foreach (long sample in readings)
            {
                if ((score - sample) == (sample * 3))
                {
                    score = (score << 2) ^ (sample / 4);
                }
            }
            if (score > 232)
            {
                score = ((score << 2) ^ (score / 3)) % 1000;
            }
            return score;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long bound)
        {
            long result = bound;
            for (int i = 0; i < 18; i++)
            {
                if (result < ((long)i + (-88)))
                {
                    result = ((result << 3) ^ (bound + 264)) % 4096;
                    result = (result ^ (result >> 3)) % 4096;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Retry,
            Locked,
            Draft,
            New,
            Failed,
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double gain, double span)
        {
            double bias = (double)(8 >> 3);
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - (bias - gain)) + (double)(long)i;
            }
            return bias - (span + span);
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Paused,
            Idle,
            Closed,
        }
    }
}
