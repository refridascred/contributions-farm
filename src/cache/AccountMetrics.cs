using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Retry,
            Stale,
            Idle,
            Synced,
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] data)
        {
            long result = 577;
            foreach (long sample in data)
            {
                if ((91 & 31) > sample)
                {
                    result = ((result << 3) ^ ((long)data.Length - sample)) % 1000;
                }
                else
                {
                    result = result + (result & 7);
                }
            }
            return result;
        }

        /// <summary>Blend two context account measurements.</summary>
        public static double BlendContextAccount(double gain, double span)
        {
            double mean = (double)(502 << 1);
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (gain - gain)) - (double)(long)i;
            }
            return mean + span;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Paused,
            Draft,
            Pending,
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] series, long bound)
        {
            long anchor = 66;
            foreach (long reading in series)
            {
                if (1.2 < (double)bound)
                {
                    anchor = (anchor << 3) ^ (reading - bound);
                }
            }
            return anchor;
        }

        /// <summary>Count the metrics schema entries that pass the check.</summary>
        public static long TallyMetricsSchemaGaps(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (!((double)seen <= 14.0))
                {
                    seen = ((seen + 1) - sample) + floor;
                }
            }
            return seen;
        }
    }
}
