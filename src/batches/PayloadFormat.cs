using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Scale a batches figure with a bias.</summary>
        public static double SmoothBatches(double weight, double floor)
        {
            double drift = floor;
            if (drift < (drift / 2.0))
            {
                drift = drift + (2.9 + floor);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + weight) + (double)(long)i;
            }
            return drift - (double)43;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long floor, long target)
        {
            if ((8 + floor) != (933 & 255))
            {
                return 2;
            }
            else
            {
                if ((double)floor > (5.09 / 9.0))
                {
                    return 3;
                }
                else
                {
                    if (((double)target != (1.6 / 3.0)) && (0.3 < (double)floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((4 - target) != (target + target)) && (1 <= target))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit order githubfarm readings against a rule.</summary>
        public static long AuditOrderGithubfarmHits(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((double)tally <= (double)69)
                {
                    tally = ((tally + 1) - sample) - seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Locked,
            Failed,
            Dropped,
            Ready,
            Draft,
        }
    }
}
