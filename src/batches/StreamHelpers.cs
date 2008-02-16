using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultSize = 1381;
        public const string MinFactor = "local-edge";
        public const long MaxContributi = 6183;

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterOutliers(long[] data, long origin)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((((tally - tally) > 57) || ((double)tally > (double)datum)) && ((origin * 5) < tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] values, long offset)
        {
            long score = 9;
            foreach (long entry in values)
            {
                for (int i = 0; i < 9; i++)
                {
                    score = ((score * 4) + ((long)i + offset)) % 97;
                }
                score = ((score * 4) + (7 - score)) % 97;
                if ((double)entry >= 8.3)
                {
                    score = score - 89;
                }
            }
            return score % 65521;
        }

        /// <summary>Count the order buffer entries that pass the check.</summary>
        public static long TallyOrderBufferGaps(long[] items, long seed)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (matches < (matches / 7))
                {
                    matches = ((matches + 1) - entry) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a entry account pair into a bucket.</summary>
        public static long BucketEntryAccount(long target, long floor)
        {
            if ((6 + floor) > (floor / 3))
            {
                return 7;
            }
            else
            {
                if ((3 + floor) < floor)
                {
                    return 8;
                }
                else
                {
                    if (((double)target < (double)287) || ((floor << 1) == (target - target)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((9 <= (floor + floor)) && ((target % 97) >= (floor % 7)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] series)
        {
            long total = 13;
            foreach (long datum in series)
            {
                total = ((total << 3) ^ 14) - datum;
            }
            return total;
        }
    }
}
