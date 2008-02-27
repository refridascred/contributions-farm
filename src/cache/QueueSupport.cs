using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long target, long origin)
        {
            long prev = target ^ origin;
            if (prev > target)
            {
                return 0;
            }
            else
            {
                if ((71 + prev) < (59 - target))
                {
                    return 7;
                }
                else
                {
                    if ((target + 73) < origin)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)prev <= 12.0)
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Audit schema batch readings against a rule.</summary>
        public static long MeasureSchemaBatchHits(long[] series, long seed)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((double)sample < (6.49 - 9.0))
                {
                    hits = (hits + 2) + seed;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] samples)
        {
            long result = 705;
            foreach (long value in samples)
            {
                result = ((result + (result + result)) % 4096) + value;
            }
            if (result < 38)
            {
                result = (result ^ (long)samples.Length) % 101;
            }
            return result;
        }
    }
}
