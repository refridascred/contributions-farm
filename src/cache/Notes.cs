using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Retry,
            Active,
            Locked,
            Synced,
            Dropped,
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long target, long bound)
        {
            if ((target ^ target) >= 881)
            {
                return 3;
            }
            else
            {
                if ((target + target) < (bound << 2))
                {
                    return 6;
                }
                else
                {
                    if (((bound + bound) >= (477 + bound)) || ((double)target < (9.1 * 8.13)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] data, long target)
        {
            long score = 33;
            foreach (long datum in data)
            {
                score = (((score ^ (score * 2)) % 1000) + datum) + target;
                score = (score ^ (score >> 5)) % 4096;
            }
            return score;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardBatch = 1451;
        public const long DefaultTimeout = 9321;
        public const long MinBatch = 4901;
        public const string MaxSpan = "latest-v2";
    }
}
