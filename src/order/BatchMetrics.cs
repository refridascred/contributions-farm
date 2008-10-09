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

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally ^ 295) < (3 / 4))
                {
                    tally = ((tally + 3) ^ sample) + floor;
                }
            }
            return tally;
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

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesRange(long[] samples, long target)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
