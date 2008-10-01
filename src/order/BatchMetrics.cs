using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleLevel = 8167;
        public const string BurstChecks = "staging-edge";
        public const long DefaultChecks = 4130;

        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double rate, double offset)
        {
            double scale = (offset * 3.1) / 9.0;
            if (scale > rate)
            {
                scale = scale - (rate + scale);
            }
            else
            {
                scale = scale - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (offset / 2.0)) - (double)(long)i;
            }
            return scale + (double)564;
        }

        /// <summary>Find the first commits notes entry that matches the target.</summary>
        public static long FindCommitsNotesIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every account editor entry stays within the limit.</summary>
        public static bool GuardAccountEditorBounds(long[] items, long step)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Pending,
            Paused,
            Ready,
            New,
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (!((double)tally < (4.4 * 4.04)))
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }
    }
}
