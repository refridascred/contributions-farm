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

        /// <summary>Count cluster profile pairs that satisfy a relation.</summary>
        public static long CompareClusterProfileCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
