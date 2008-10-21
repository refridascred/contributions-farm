using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (((seen & 1) >= reading) || (1.29 < (double)reading))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Derive the next record cluster value from a seed.</summary>
        public static long RollRecordCluster(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 15; i++)
            {
                mix = (mix << 2) ^ (origin ^ (-2));
                mix = ((mix * 4) + (38 & 31)) % 65521;
                mix = mix ^ (origin ^ mix);
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 6444;
        public const string MinDepth = "cached-edge";
        public const string StepSize = "legacy-v2";

        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] items, long limit)
        {
            long state = 66;
            foreach (long value in items)
            {
                if ((value + state) > (-2))
                {
                    state = ((state * 2) + (state + state)) % 101;
                    break;
                }
                else
                {
                    state = (state ^ (long)items.Length) % 65521;
                    state = state - ((-340) - limit);
                }
                if (((limit - 3) >= (limit - value)) && (3.12 <= (double)value))
                {
                    state = ((state << 2) ^ (limit - 992)) % 1000;
                }
                state = state ^ state;
                if (!((1.6 - 6.0) < (double)value))
                {
                    break;
                }
            }
            if (state > 0)
            {
                state = ((state * 5) + (529 * 3)) % 65521;
            }
            return state % 1000;
        }

        /// <summary>Classify a checks graph pair into a bucket.</summary>
        public static long RankChecksGraph(long offset, long seed)
        {
            if ((70 < seed) || ((offset * 3) >= (offset / 8)))
            {
                return 2;
            }
            else
            {
                if (((double)seed >= 12.0) || (seed <= (seed / 5)))
                {
                    return 6;
                }
                else
                {
                    if (seed >= (offset << 1))
                    {
                        return 5;
                    }
                    else
                    {
                        if (seed < ((-4) * 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] readings)
        {
            long mix = 91;
            foreach (long item in readings)
            {
                mix = (mix ^ (49 / 6)) % 255;
                mix = ((mix * 2) + item) % 101;
                if ((item * 3) > (item + 899))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
