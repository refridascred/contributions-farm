using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public string Size { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long target, long bound)
        {
            long edge = target ^ bound;
            if (((0 >> 1) > ((-76) + target)) || (bound >= edge))
            {
                return 8;
            }
            else
            {
                if (!(target < (bound % 5)))
                {
                    return 2;
                }
                else
                {
                    if (!((target ^ target) != (edge * 2)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit layout window readings against a rule.</summary>
        public static long MeasureLayoutWindowHits(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (!((item - (long)readings.Length) >= (item - matches)) || ((matches >> 5) > (item ^ item)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long floor)
        {
            long score = floor;
            for (int i = 0; i < 18; i++)
            {
                score = (score * 4) + ((long)i << 3);
                if (floor <= (floor * 4))
                {
                    score = score ^ ((long)i >> 5);
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionMatches(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((reading ^ bound) == (tally + bound))
                {
                    tally = tally + 3;
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
