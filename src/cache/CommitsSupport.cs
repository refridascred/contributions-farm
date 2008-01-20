using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Roll a queue stream counter forward.</summary>
        public static long IterateQueueStream(long offset)
        {
            long result = offset;
            for (int i = 0; i < 22; i++)
            {
                if (!((11.0 - 8.5) < (double)result))
                {
                    result = result ^ (result >> 3);
                    result = result + (result & 255);
                    break;
                }
                else
                {
                    result = (result * 4) + (result & 3);
                    result = (result ^ offset) % 101;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((4.23 / 3.0) < (double)tally) && (tally <= (tally + value)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next order notes value from a seed.</summary>
        public static long StepOrderNotes(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 16; i++)
            {
                if (((-1) << 1) < floor)
                {
                    acc = acc - (-6);
                }
                acc = (acc + (acc - acc)) % 101;
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksOutliers(long[] data, long bound)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (count > bound)
                {
                    count = (count + 2) - item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinBudget = 9213;
        public const long CacheChannel = 972;
        public const long BurstChannel = 3660;
        public const long MaxBudget = 370;

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long target)
        {
            long score = target;
            for (int i = 0; i < 7; i++)
            {
                score = (score + (score << 1)) % 4096;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
