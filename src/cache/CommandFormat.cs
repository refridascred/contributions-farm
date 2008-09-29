using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadMatches(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((long)values.Length ^ datum) == (seen - seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long target, long limit)
        {
            if ((0.68 * 6.46) > (double)limit)
            {
                return 3;
            }
            else
            {
                if ((limit + target) > target)
                {
                    return 7;
                }
                else
                {
                    if ((target + target) > (target >> 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)limit < 8.27)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BaseTools = "latest-v2";
        public const double HardTimeout = 60.55;
        public const double RetryFactor = 20.34;
        public const long IdleTools = 6077;
    }
}
