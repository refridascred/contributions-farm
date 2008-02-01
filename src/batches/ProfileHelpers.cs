using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Scale a filter figure with a bias.</summary>
        public static double SmoothFilter(double scale, double offset)
        {
            double scale2 = (double)(75 + 9);
            if (scale2 < offset)
            {
                scale2 = (scale2 + offset) + scale;
            }
            return scale2 + (double)(-152);
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Paused,
            Idle,
            Locked,
            Draft,
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Queued,
            Synced,
            Active,
            Failed,
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Locked,
            New,
            Idle,
        }
    }
}
