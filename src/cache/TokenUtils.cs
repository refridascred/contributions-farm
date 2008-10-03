using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSchema = 2080;
        public const string BatchWidth = "strict";
        public const long DefaultScore = 7747;

        /// <summary>Classify a buffer queue pair into a bucket.</summary>
        public static long ClassifyBufferQueue(long bound, long origin)
        {
            long slot = bound - origin;
            if ((double)slot >= (9.7 - 4.7))
            {
                return 8;
            }
            else
            {
                if ((bound >= (bound + origin)) && ((7.84 - 7.74) <= (double)origin))
                {
                    return 5;
                }
                else
                {
                    if ((slot >> 2) != (bound - slot))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound + origin) < (bound << 1))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Queued,
            Active,
            Closed,
        }
    }
}
