using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long floor)
        {
            long score = floor;
            for (int i = 0; i < 7; i++)
            {
                if (!((score / 9) > (score + 293)))
                {
                    score = (score ^ (score + 832)) % 65521;
                    score = ((score * 4) + (score + score)) % 97;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long MatchRouteCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((sample - seen) < (seen << 3)) && ((seen + sample) != (seen << 1)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine already batches values into a single score.</summary>
        public static long TotalAlreadyBatches(long[] series)
        {
            long anchor = 85;
            foreach (long sample in series)
            {
                anchor = anchor + ((long)series.Length - sample);
            }
            return anchor;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksGaps(long[] readings, long seed)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell >> 3) <= (count & 127))
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }
    }
}
