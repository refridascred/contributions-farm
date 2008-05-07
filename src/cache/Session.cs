using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Stale,
            Synced,
            Failed,
            New,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string StepScore = "open";
        public const long HardFarm = 2439;
        public const long DefaultFactor = 1017;

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long GradeFarm(long step, long target)
        {
            long cur = step ^ target;
            if ((cur - step) > (step * 5))
            {
                return 2;
            }
            else
            {
                if (((5.69 * 4.2) > (double)step) || ((double)step < (1.3 - 3.2)))
                {
                    return 0;
                }
                else
                {
                    if (cur >= (step ^ target))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheBounds(long[] series, long offset)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
