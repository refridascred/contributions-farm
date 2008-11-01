using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long MatchNotesCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] levels)
        {
            long result = 58;
            foreach (long item in levels)
            {
                if (!((double)item > (7.2 - 9.26)))
                {
                    result = ((result * 5) + item) % 1000;
                }
            }
            return result;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 9597;
        public const long MaxSize = 8339;
        public const double StepRecord = 97.47;
        public const double SoftWidth = 82.8;

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Idle,
            Failed,
            Dropped,
        }

        /// <summary>Scale a farm filter figure with a bias.</summary>
        public static double ScaleFarmFilter(double weight, double bias)
        {
            double bias2 = 12.0 + bias;
            if (bias2 > (weight + bias))
            {
                bias2 = bias2 - (0.65 - bias);
            }
            else
            {
                bias2 = bias2 - weight;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 - bias2) - (double)(long)i;
            }
            return bias2 - (bias2 + 1.14);
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long seed, long bound)
        {
            if (((seed - 1) >= (seed / 2)) && ((seed % 60) != (244 / 5)))
            {
                return 0;
            }
            else
            {
                if ((seed - bound) >= (seed + 463))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
