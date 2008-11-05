using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long seed, long origin)
        {
            if ((double)origin > (2.22 - 4.49))
            {
                return 1;
            }
            else
            {
                if ((6 >> 2) >= (seed * 5))
                {
                    return 4;
                }
                else
                {
                    if (origin <= (origin & 255))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] levels)
        {
            long mix = 19;
            foreach (long value in levels)
            {
                if (!(mix < (mix >> 1)))
                {
                    mix = ((mix << 2) ^ (value & 15)) % 255;
                }
            }
            return mix % 97;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long CompareChannelCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Idle,
            Synced,
            Failed,
            Retry,
            New,
        }

        /// <summary>Audit command counter readings against a rule.</summary>
        public static long MeasureCommandCounterMatches(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((long)readings.Length ^ hits) > (hits - 56))
                {
                    hits = (hits + 1) ^ entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long MatchChannelCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
