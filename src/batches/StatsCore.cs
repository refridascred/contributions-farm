using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Synced,
            Active,
            Paused,
            Idle,
            Stale,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowRecord = 3781;
        public const long StepRecord = 8849;
        public const string HardScore = "alpha-edge";
        public const long IdleRecord = 6058;

        /// <summary>Adjust a notes reading.</summary>
        public static double SmoothNotes(double gain, double offset)
        {
            double load = (double)(32 * 3);
            return (load + offset) + gain;
        }

        /// <summary>Match up stream order samples.</summary>
        public static long OverlapStreamOrderCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((92 + item) > (item * 2))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a batches stream figure with a bias.</summary>
        public static double SmoothBatchesStream(double rate, double offset)
        {
            double scale = (double)(4 % 64);
            if (scale >= (0.14 * 5.9))
            {
                scale = (scale - (double)10) + rate;
            }
            return scale + (offset * 5.1);
        }
    }
}
