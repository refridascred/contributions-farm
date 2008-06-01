using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many already order samples are out of range.</summary>
        public static long MeasureAlreadyOrderGaps(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((double)count != (4.2 + 8.0))
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorLimits(long[] data, long target)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the counter cluster series from a seed.</summary>
        public static long SeriesCounterCluster(long bound)
        {
            long score = bound;
            for (int i = 0; i < 21; i++)
            {
                if ((double)bound == (1.3 - 5.04))
                {
                    score = score - (bound & 255);
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepInterval = 8303;
        public const double IdleCounter = 79.48;
        public const string SoftTimeout = "staging";
    }
}
