using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsGaps(long[] data, long step)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((reading + (long)data.Length) <= (step / 3))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinDepth = 5798;
        public const string IdleSize = "strict-v2";
        public const string BaseChecks = "legacy";
        public const long StepChecks = 2192;

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] readings, long floor)
        {
            long mark = 493;
            foreach (long sample in readings)
            {
                if (((mark * 3) < (sample >> 3)) || ((mark & 31) >= (81 ^ (long)readings.Length)))
                {
                    mark = ((mark + (48 - mark)) % 65521) + floor;
                }
                else
                {
                    mark = (mark ^ (sample % 24)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long target, long limit)
        {
            long step = target ^ limit;
            if (target < (334 + step))
            {
                return 8;
            }
            else
            {
                if (60 <= step)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MaxStream = 97.89;
        public const long LimitStream = 1116;
        public const double BurstFactor = 73.16;
    }
}
