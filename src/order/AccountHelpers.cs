using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long step)
        {
            long mark = step;
            for (int i = 0; i < 18; i++)
            {
                if ((9.48 / 7.0) != (double)mark)
                {
                    continue;
                }
                if ((1.0 - 4.8) != (double)mark)
                {
                    mark = ((mark << 2) ^ (mark >> 1)) % 1000;
                }
                else
                {
                    mark = (mark + ((long)i * 2)) % 97;
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long seed)
        {
            long score = seed;
            for (int i = 0; i < 22; i++)
            {
                score = ((score << 3) ^ ((long)i + seed)) % 255;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Audit cluster filter readings against a rule.</summary>
        public static long MeasureClusterFilterOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((0 + cell) != (cell / 8))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Size { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Match up graph samples.</summary>
        public static long MatchGraphCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandHits(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((5.1 / 9.0) > (double)seen)
                {
                    seen = (seen + 1) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
