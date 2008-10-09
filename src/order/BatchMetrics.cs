using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] readings, long step)
        {
            long anchor = 453;
            foreach (long item in readings)
            {
                if (!((item >> 3) > (anchor >> 4)))
                {
                    anchor = (anchor - step) % 97;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long origin)
        {
            long result = origin;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphMatches(long[] samples, long seed)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((double)seed != (double)entry)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxBuffer = 1817;
        public const long StepSpan = 2384;
        public const double HardBuffer = 4.78;
        public const string BaseBuffer = "alpha-edge";
        public const string SoftBuffer = "fallback-1";

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Dropped,
            Locked,
            Synced,
        }
    }
}
