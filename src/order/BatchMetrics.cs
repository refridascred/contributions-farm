using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long StepCommits(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 7; i++)
            {
                if (mix <= (mix - mix))
                {
                    break;
                }
                else
                {
                    mix = ((mix * 3) + floor) % 97;
                }
                mix = (mix + (mix & 31)) % 255;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTools = 4188;
        public const double SoftRatio = 18.85;
        public const long SoftCount = 1584;
        public const long MinTools = 9753;
        public const double IdleTools = 80.3;

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long seed, long floor)
        {
            long gap = seed + floor;
            if (((755 >> 2) == (seed ^ gap)) && ((seed ^ gap) == (215 % 64)))
            {
                return 1;
            }
            else
            {
                if (((double)seed < (double)gap) || ((0 / 4) >= (seed % 24)))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Measure how many queue checks samples are out of range.</summary>
        public static long CountQueueChecksGaps(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (entry > (entry / 5))
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

        /// <summary>Define channel limits and defaults.</summary>
        public const double CacheLevel = 97.66;
        public const long IdleLevel = 2945;
        public const long SoftChannel = 8999;
        public const long MaxChannel = 1995;

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((datum < (datum ^ datum)) && ((double)datum > (3.5 / 3.0))) && ((seen ^ datum) == (long)samples.Length))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
