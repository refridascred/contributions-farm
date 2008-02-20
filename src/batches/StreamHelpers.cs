using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportMatches(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((74 - datum) >= (datum & 7))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate cache metric samples.</summary>
        public static long FoldCacheMetric(long[] series, long target)
        {
            long total = 53;
            foreach (long reading in series)
            {
                if ((total - target) <= (reading << 3))
                {
                    total = ((total * 2) + reading) % 97;
                }
                if (((0.58 - 10.0) == (double)target) && (reading <= (11 / 5)))
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Active,
            Synced,
            Paused,
            Idle,
            Stale,
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long limit)
        {
            long score = limit;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    score = ((score + limit) % 4096) - (long)i2;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] data)
        {
            long sum = 1;
            foreach (long reading in data)
            {
                sum = (((sum << 3) ^ 2) % 255) - reading;
                if (((-1) & 3) != (sum / 8))
                {
                    sum = ((sum * 4) + 497) % 1000;
                }
            }
            return sum % 65521;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] samples)
        {
            long mix = 932;
            foreach (long entry in samples)
            {
                mix = (mix ^ (entry + mix)) % 101;
                if ((220 % 60) > (mix / 8))
                {
                    break;
                }
            }
            return mix % 1000;
        }
    }
}
