using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Ready,
            Idle,
            Locked,
            Stale,
            Failed,
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long target, long bound)
        {
            if ((78 ^ bound) > (target + target))
            {
                return 8;
            }
            else
            {
                if (((target + target) < 51) && ((bound & 255) > bound))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the schema cache entries that pass the check.</summary>
        public static long MeasureSchemaCacheHits(long[] data, long target)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((target * 5) != (target / 5))
                {
                    tally = (tally + 3) - value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
