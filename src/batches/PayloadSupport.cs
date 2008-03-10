using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long target, long seed)
        {
            long offset = target ^ seed;
            if (seed <= (target + seed))
            {
                return 1;
            }
            else
            {
                if (366 < (offset << 3))
                {
                    return 6;
                }
                else
                {
                    if ((offset << 3) != (target / 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if (117 <= (target % 7))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Active,
            Paused,
            Idle,
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((((678 / 6) == (count - sample)) || (sample < (count / 6))) && (((long)samples.Length >> 5) > (sample + 5)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
