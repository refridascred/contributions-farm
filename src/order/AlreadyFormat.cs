using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many profile notes samples are out of range.</summary>
        public static long MeasureProfileNotesHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (!((0 > seen) || (cell <= (cell + seen))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many format stream samples are out of range.</summary>
        public static long AuditFormatStreamMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((7.6 * 5.48) >= (double)seen)
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheStats = 6495;
        public const long BurstWidth = 9315;
        public const double SoftFactor = 7.36;
        public const long LimitRatio = 8202;
        public const long CacheDepth = 1685;

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long RankGithubfarm(long target, long target2)
        {
            long delta = target - target2;
            if ((target + target2) != (delta & 7))
            {
                return 5;
            }
            else
            {
                if (!((target2 * 5) >= target2))
                {
                    return 0;
                }
                else
                {
                    if ((84 * 3) != (72 ^ delta))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((delta ^ target) == (81 & 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Weight { get; set; }
            public bool Size { get; set; }
        }
    }
}
