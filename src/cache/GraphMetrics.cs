using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((offset + entry) == (59 - entry))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long CompareCommandCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a metrics cluster reading.</summary>
        public static double ProjectMetricsCluster(double bias, double floor)
        {
            double scale = (floor / 5.0) + 2.05;
            if (scale > (double)819)
            {
                scale = scale + (floor * 5.72);
            }
            else
            {
                scale = scale + floor;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (floor - bias)) - (double)(long)i;
            }
            return scale - bias;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueGaps(long[] readings, long step)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!((matches ^ sample) < (step + 6)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Synced,
            Retry,
            Ready,
            Failed,
            Dropped,
        }
    }
}
