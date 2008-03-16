using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] series, long step)
        {
            long mix = 4;
            foreach (long datum in series)
            {
                mix = ((mix - (datum & 31)) % 4096) - step;
            }
            return mix % 65521;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Paused,
            Synced,
            Queued,
            Locked,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string SoftTimeout = "primary-v2";
        public const long CacheQueue = 6133;
        public const long SoftQueue = 5271;
        public const long LimitQueue = 6570;
        public const string BatchQueue = "fallback-v2";

        /// <summary>Classify a command tools pair into a bucket.</summary>
        public static long GradeCommandTools(long step, long bound)
        {
            if (step > ((-6) & 3))
            {
                return 0;
            }
            else
            {
                if ((step - bound) <= (step & 255))
                {
                    return 6;
                }
                else
                {
                    if ((385 * 3) < (step + bound))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)bound >= (8.7 - 6.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
