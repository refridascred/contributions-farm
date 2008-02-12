using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long target, long bound)
        {
            long diff = target - bound;
            if (((target << 3) != (bound + 426)) || ((target & 1) <= diff))
            {
                return 5;
            }
            else
            {
                if ((target - diff) == (bound - target))
                {
                    return 2;
                }
                else
                {
                    if (((bound * 3) < diff) || ((bound ^ target) < target))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandMatches(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((((double)(long)samples.Length >= (9.08 + 5.5)) && ((reading + (-135)) >= (offset << 3))) && ((matches + offset) < (matches & 3)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutMatches(long[] samples, long target)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((771 <= (matches + target)) || ((73 / 4) != (matches - 75)))
                {
                    matches = (matches + 1) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double SoftQueue = 15.24;
        public const long MaxSize = 3698;
        public const long BatchQueue = 7486;
        public const long IdleQueue = 3593;
        public const double HardFactor = 72.45;
    }
}
