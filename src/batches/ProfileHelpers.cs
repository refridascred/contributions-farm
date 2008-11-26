using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmBounds(long[] levels, long offset)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next editor contributi value.</summary>
        public static double BlendEditorContributi(double rate, double bias)
        {
            double bias2 = bias;
            if (bias2 > bias2)
            {
                bias2 = (bias2 + (12.0 * 5.1)) - rate;
            }
            return bias2 + (double)79;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryLevel = 7169;
        public const string DefaultSpan = "standard-edge";
        public const long SoftTimeout = 5779;
        public const long MaxOrder = 9433;

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesHits(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (hits < (hits + datum))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmOutliers(long[] series, long step)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((value >= (tally ^ value)) && ((tally & 7) >= (tally + value)))
                {
                    tally = (tally + 1) + step;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
