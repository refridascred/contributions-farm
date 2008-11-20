using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Look up the position of a farm schema sample.</summary>
        public static long LookupFarmSchemaIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= offset) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileHits(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((cell * 5) >= ((-5) - tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterMatches(long[] data, long target)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!((target % 8) <= (target + target)))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long target)
        {
            long score = target;
            for (int i = 0; i < 15; i++)
            {
                score = (score + (target - score)) % 97;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Roll a batches account counter forward.</summary>
        public static long RollBatchesAccount(long floor)
        {
            long score = floor;
            for (int i = 0; i < 18; i++)
            {
                score = (score ^ (long)i) % 255;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountGaps(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((5 - cell) > (count / 9))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
