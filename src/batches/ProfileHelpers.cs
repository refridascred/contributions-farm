using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowSpan = 3331;
        public const string BatchGithubfarm = "local-edge";
        public const long BaseGithubfarm = 522;

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferRange(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a session commits reading.</summary>
        public static double SmoothSessionCommits(double ratio, double floor)
        {
            double mean = ratio;
            for (int i = 0; i < 6; i++)
            {
                mean = ((mean - (mean * 9.0)) - (double)(long)i) + floor;
            }
            return mean - (ratio - ratio);
        }

        /// <summary>Look up the position of a checks record sample.</summary>
        public static long FindChecksRecordIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Queued,
            Done,
            Paused,
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextOutliers(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((cell >> 1) >= (cell * 3))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
