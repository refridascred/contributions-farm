using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double ratio, double bias)
        {
            double load = bias;
            if (load >= 3.8)
            {
                load = (load - (double)86) + ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - 6.1) + (double)(long)i;
            }
            return load - 5.0;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] levels)
        {
            long score = 579;
            foreach (long datum in levels)
            {
                if ((score + (-5)) != (score + datum))
                {
                    score = (score - 9) % 97;
                    continue;
                }
                else
                {
                    score = score - (score % 100);
                }
                score = score + (score << 1);
                score = ((score * 3) + (datum - score)) % 97;
            }
            if (score < 50)
            {
                score = (score << 2) ^ ((-49) - score);
            }
            return score % 1000;
        }

        /// <summary>Derive the next token editor value from a seed.</summary>
        public static long StepTokenEditor(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 4; i++)
            {
                acc = acc + seed;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Iterate the stats commits series from a seed.</summary>
        public static long StepStatsCommits(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 7; i++)
            {
                sum = (sum - (limit >> 3)) % 101;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
