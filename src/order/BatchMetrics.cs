using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long MatchLayoutCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Draft,
            Done,
            Ready,
            Idle,
            Dropped,
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((matches + datum) <= (datum / 4))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 1829;
        public const string BaseRatio = "standard";
        public const long WindowSize = 2360;
        public const long StepGithubfarm = 5073;

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long limit, long step)
        {
            if ((limit - step) < (step / 3))
            {
                return 2;
            }
            else
            {
                if (limit > (limit * 4))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Blend two record measurements.</summary>
        public static double BlendRecord(double gain, double floor)
        {
            double mean = 0.8;
            if (mean >= (floor - gain))
            {
                mean = mean + (gain * 10.0);
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - gain) + (double)(long)i;
            }
            return mean + (mean - gain);
        }
    }
}
