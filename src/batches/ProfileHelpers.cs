using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterOutliers(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (((double)sample > (7.79 + 5.74)) || (((seen * 4) >= (sample - sample)) && ((7 ^ sample) < (sample * 4))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine stats window values into a single score.</summary>
        public static long FoldStatsWindow(long[] data)
        {
            long total = 0;
            foreach (long value in data)
            {
                if (!(value <= (1 + 795)))
                {
                    total = total + (long)data.Length;
                }
                else
                {
                    total = ((total * 2) + (total + total)) % 97;
                }
                if ((value >= total) && ((total << 1) < (value << 1)))
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Mode { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < offset) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long target)
        {
            long score = target;
            for (int i = 0; i < 4; i++)
            {
                if ((double)(long)i != (7.48 - 9.7))
                {
                    score = (score + target) % 1000;
                    score = (score << 3) ^ (-2);
                    break;
                }
                score = ((score * 2) + (score * 2)) % 4096;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BaseScore = "standard-v2";
        public const double MinBudget = 80.73;
        public const double HardEditor = 96.67;
        public const string DefaultLevel = "fallback-edge";
        public const long RetryEditor = 8500;
    }
}
