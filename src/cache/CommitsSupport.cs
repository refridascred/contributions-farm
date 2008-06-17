using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] readings)
        {
            long score = 94;
            foreach (long item in readings)
            {
                for (int i = 0; i < 7; i++)
                {
                    score = (((score * 4) + (item << 1)) % 97) - (long)i;
                    score = score ^ score;
                }
                score = score ^ (score - item);
            }
            return score;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Idle,
            Done,
            Synced,
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Draft,
            Done,
            Retry,
            Failed,
        }

        /// <summary>Project the next tools value.</summary>
        public static double BlendTools(double gain, double offset)
        {
            double ratio = 12.0 / 4.0;
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio + ratio) + (double)(long)i) + offset;
            }
            return ratio - gain;
        }
    }
}
