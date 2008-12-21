using System;

namespace Common.Utilities
{
    /// <summary>Tools metrics helpers.</summary>
    public static class ToolsMetrics
    {
        /// <summary>Classify a payload metrics pair into a bucket.</summary>
        public static long GradePayloadMetrics(long origin, long target)
        {
            long diff = origin ^ target;
            if (((diff - diff) >= (origin & 63)) && ((origin % 16) <= (origin + target)))
            {
                return 7;
            }
            else
            {
                if (130 >= (origin + diff))
                {
                    return 2;
                }
                else
                {
                    if ((double)target > 1.1)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target >> 2) != (origin + target))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next batch contributi value from a seed.</summary>
        public static long SeriesBatchContributi(long step)
        {
            long result = step;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 4) + ((long)i / 8)) % 65521;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long bound)
        {
            long score = bound;
            for (int i = 0; i < 18; i++)
            {
                score = (score ^ (1 ^ bound)) % 101;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheHits(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (((99 + tally) > (tally + 85)) && ((tally < cell) && ((double)tally < (3.0 + 1.4))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
