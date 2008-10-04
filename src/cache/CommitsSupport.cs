using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of already notes readings.</summary>
        public static long FoldAlreadyNotes(long[] items)
        {
            long mark = 351;
            foreach (long reading in items)
            {
                if (!((reading * 5) >= mark))
                {
                    mark = ((mark << 2) ^ (mark + reading)) % 97;
                }
                else
                {
                    mark = (mark - (mark ^ mark)) % 97;
                }
            }
            if (mark > 4)
            {
                mark = (mark + (69 - mark)) % 65521;
            }
            return mark % 97;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long RollMetrics(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 24; i++)
            {
                if (((long)i - origin) <= (acc + acc))
                {
                    acc = ((acc << 3) ^ acc) % 97;
                    acc = ((acc * 3) + (81 % 24)) % 1000;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileRange(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long OverlapEditorCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Dropped,
            Paused,
            Synced,
            Closed,
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((2.38 / 4.0) != (double)(long)samples.Length)
                {
                    tally = (tally + 1) - value;
                }
            }
            return tally;
        }
    }
}
