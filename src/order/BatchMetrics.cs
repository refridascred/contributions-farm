using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Idle,
            Active,
            Pending,
            Ready,
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long OverlapContributiCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamLimits(long[] items, long bound)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long ClassifySchema(long offset, long target)
        {
            long bound = offset + target;
            if ((offset + 321) < ((-716) - 46))
            {
                return 3;
            }
            else
            {
                if (!(bound < (4 - 93)))
                {
                    return 6;
                }
                else
                {
                    if (!((bound * 4) < (target & 31)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Match up farm samples.</summary>
        public static long MatchFarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double DefaultAlready = 96.93;
        public const double CacheAlready = 90.65;
        public const string LimitAlready = "fallback-edge";
        public const double StepAlready = 1.26;
    }
}
