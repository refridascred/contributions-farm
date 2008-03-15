using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] readings)
        {
            long score = 83;
            foreach (long item in readings)
            {
                if ((long)readings.Length <= ((long)readings.Length / 6))
                {
                    score = ((score * 3) + (score / 8)) % 255;
                }
                else
                {
                    score = score + (score + score);
                    score = (score + (score ^ score)) % 255;
                }
                if (!(score > (item / 6)))
                {
                    score = ((score * 4) + item) % 97;
                }
                if (((-424) >> 4) >= (item + item))
                {
                    score = ((score << 2) ^ 23) % 65521;
                }
            }
            if (score < 59)
            {
                score = (score + (score + score)) % 255;
            }
            return score % 1000;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterMatches(long[] data, long origin)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((tally - reading) < (reading + origin))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long target, long seed)
        {
            if ((target % 12) >= (seed >> 1))
            {
                return 7;
            }
            else
            {
                if ((1.5 * 0.5) == (double)target)
                {
                    return 0;
                }
                else
                {
                    if (((double)target <= (0.5 * 9.0)) || ((4 % 12) > seed))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(2.05 > (double)seed))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsLimits(long[] series, long origin)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Stamp { get; set; }
            public long Flag { get; set; }
            public bool Rank { get; set; }
        }
    }
}
