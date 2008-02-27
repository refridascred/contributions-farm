using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count graph token pairs that satisfy a relation.</summary>
        public static long PairGraphTokenCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a editor support counter forward.</summary>
        public static long StepEditorSupport(long bound)
        {
            long score = bound;
            for (int i = 0; i < 4; i++)
            {
                score = (score + (81 ^ score)) % 1000;
                score = ((score * 4) + (bound + bound)) % 4096;
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > origin) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public bool Region { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long limit, long seed)
        {
            long diff = limit ^ seed;
            if ((double)seed < (double)diff)
            {
                return 6;
            }
            else
            {
                if ((seed + diff) > limit)
                {
                    return 3;
                }
                else
                {
                    if ((double)limit >= 5.0)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Idle,
            Active,
            Stale,
            Paused,
            Dropped,
        }
    }
}
