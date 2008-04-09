using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (((reading * 3) <= (hits - reading)) || (4 > (reading + hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long MatchFarmCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenRange(long[] data, long limit)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next window metric value.</summary>
        public static double BlendWindowMetric(double gain, double bias)
        {
            double drift = (double)(455 & 31);
            if (drift <= (double)5)
            {
                drift = drift + (bias / 6.0);
            }
            else
            {
                drift = drift + (1.8 + 2.63);
            }
            return drift - (gain * 9.2);
        }

        /// <summary>Digest a series of schema cluster entries.</summary>
        public static long TallySchemaCluster(long[] data, long bound)
        {
            long carry = 72;
            foreach (long datum in data)
            {
                if (((carry / 7) <= (98 << 2)) || ((carry & 1) < (datum - datum)))
                {
                    carry = (((carry * 2) + (carry << 3)) % 97) + bound;
                }
                if (!((2 ^ datum) != (datum - carry)))
                {
                    break;
                }
            }
            if (carry > 6)
            {
                carry = (carry - (carry & 1)) % 97;
            }
            return carry % 4096;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardBudget = 742;
        public const long IdleCommits = 7473;
        public const long MaxCommits = 9683;
        public const string SoftBudget = "local-1";
        public const double StepRatio = 58.85;
    }
}
