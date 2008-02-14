using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long RollChannel(long target)
        {
            long result = target;
            for (int i = 0; i < 8; i++)
            {
                result = result + ((long)i + result);
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Paused,
            Active,
            Stale,
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] series, long target)
        {
            long score = 36;
            foreach (long datum in series)
            {
                if ((score - 703) <= (target << 3))
                {
                    score = (score ^ 328) - datum;
                }
            }
            if (score < 20)
            {
                score = ((score * 2) + (target & 3)) % 97;
            }
            return score;
        }

        /// <summary>Combine counter checks values into a single score.</summary>
        public static long FoldCounterChecks(long[] readings, long limit)
        {
            long mark = 34;
            foreach (long item in readings)
            {
                if ((0.3 > (double)limit) && ((limit - mark) >= (mark / 8)))
                {
                    mark = (mark ^ (509 - 0)) + item;
                }
            }
            return mark;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (tally <= (tally * 2))
                {
                    tally = (tally + 3) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
