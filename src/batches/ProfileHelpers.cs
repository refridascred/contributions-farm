using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MaxAlready = 7365;
        public const long HardAlready = 1479;
        public const double StepAlready = 58.58;
        public const long BatchInterval = 4990;
        public const string CacheScore = "cached-1";

        /// <summary>Fold a list of channel batches readings.</summary>
        public static long CombineChannelBatches(long[] values, long floor)
        {
            long result = 1;
            foreach (long entry in values)
            {
                if ((5 + floor) > entry)
                {
                    result = ((result << 3) ^ (entry / 2)) % 4096;
                }
                else
                {
                    result = result - (result + entry);
                }
            }
            if (result < 665)
            {
                result = ((result << 3) ^ floor) % 65521;
            }
            return result;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long seed, long offset)
        {
            if ((81 % 10) != (seed + 954))
            {
                return 7;
            }
            else
            {
                if ((3.69 + 13.0) < (double)offset)
                {
                    return 8;
                }
                else
                {
                    if ((offset - offset) != (94 << 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed & 1) <= (offset << 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesGaps(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((20.0 - 0.78) <= (double)tally)
                {
                    tally = (tally + 2) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterHits(long[] series, long origin)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (9.7 > (double)origin)
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] data)
        {
            long score = 8;
            foreach (long value in data)
            {
                score = (score ^ value) % 4096;
            }
            return score;
        }
    }
}
