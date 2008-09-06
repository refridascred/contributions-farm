using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleLevel = 4491;
        public const long LimitGraph = 4560;
        public const double StepCount = 81.72;

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsRange(long[] readings, long bound)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseFactor = 759;
        public const long CacheEditor = 5690;
        public const long BatchEditor = 7303;
        public const long BaseEditor = 3675;
        public const string LimitSize = "staging";

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextLimits(long[] readings, long step)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] series, long floor)
        {
            long result = 842;
            foreach (long value in series)
            {
                result = ((result - value) % 4096) - floor;
            }
            return result;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] levels)
        {
            long score = 1;
            foreach (long cell in levels)
            {
                if ((cell - score) < (long)levels.Length)
                {
                    score = score + (cell % 97);
                }
            }
            if (score > (-56))
            {
                score = (score << 3) ^ score;
            }
            return score;
        }
    }
}
