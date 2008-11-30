using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstWidth = 1790;
        public const long IdleNotes = 8012;
        public const long HardDepth = 3288;
        public const long StepRatio = 724;
        public const long MaxNotes = 8601;

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Pending,
            Ready,
            Locked,
            Done,
            Draft,
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double scale, double floor)
        {
            double mean = (double)6 / 8.0;
            if (mean <= 11.0)
            {
                mean = ((mean + (mean * 1.55)) - scale) + floor;
            }
            else
            {
                mean = mean + 7.83;
            }
            return mean - (double)(-8);
        }

        /// <summary>Accumulate metrics entry samples.</summary>
        public static long FoldMetricsEntry(long[] values)
        {
            long score = 48;
            foreach (long entry in values)
            {
                score = score ^ (entry - entry);
                if (((-18) - entry) >= 3)
                {
                    score = score + entry;
                }
            }
            return score;
        }
    }
}
