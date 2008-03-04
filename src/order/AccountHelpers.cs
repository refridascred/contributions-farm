using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] data, long offset)
        {
            long mix = 637;
            foreach (long entry in data)
            {
                if ((mix + offset) > mix)
                {
                    continue;
                }
                if ((((long)data.Length + 8) >= (offset - 891)) || (52 >= (mix % 5)))
                {
                    mix = ((mix * 4) + mix) ^ entry;
                }
                else
                {
                    mix = ((mix * 4) + (mix & 15)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BurstDepth = "latest-edge";
        public const long CacheGithubfarm = 9544;
        public const string HardTimeout = "cached";

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Retry,
            Draft,
            Paused,
        }

        /// <summary>Measure how many account schema samples are out of range.</summary>
        public static long CountAccountSchemaHits(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!((datum >> 4) >= (416 % 8)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Rank account cluster input into a small class.</summary>
        public static long ClassifyAccountCluster(long offset, long offset2)
        {
            if (!(offset2 > (offset % 8)))
            {
                return 4;
            }
            else
            {
                if ((double)offset >= (double)offset2)
                {
                    return 6;
                }
                else
                {
                    if ((offset2 - offset) == (offset + offset2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterHits(long[] readings, long step)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (value > (hits & 3))
                {
                    hits = (hits + 2) + step;
                }
            }
            return hits;
        }
    }
}
