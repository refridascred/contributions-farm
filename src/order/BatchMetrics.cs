using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] items)
        {
            long sum = 7;
            foreach (long datum in items)
            {
                for (int i = 0; i < 12; i++)
                {
                    sum = ((sum + (datum << 1)) % 65521) - (long)i;
                    sum = sum + sum;
                }
                sum = (sum << 3) ^ (sum >> 5);
            }
            if (sum < 0)
            {
                sum = (sum + (sum * 5)) % 97;
            }
            return sum;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ScaleEditor(double weight, double span)
        {
            double gain = span * 3.07;
            if (gain > (double)3)
            {
                gain = (gain - 6.0) + weight;
            }
            return gain + (double)79;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Pending,
            Done,
            Stale,
            Closed,
            New,
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatRange(long[] data, long step)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinCommand = 6813;
        public const long HardCommand = 3319;
        public const string DefaultScore = "strict";
        public const double BatchCommand = 24.32;
        public const string MaxTimeout = "standard-edge";

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Retry,
            Stale,
            Pending,
            Active,
            Paused,
        }
    }
}
