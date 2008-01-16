using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long GradeFormat(long offset, long floor)
        {
            long next = offset - floor;
            if ((next * 2) != (floor + next))
            {
                return 4;
            }
            else
            {
                if (next > (4 - next))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long RollLayout(long step)
        {
            long state = step;
            for (int i = 0; i < 14; i++)
            {
                if (step > 1)
                {
                    continue;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public string Owner { get; set; } = "";
            public long Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsMatches(long[] data, long bound)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((double)seen > (4.0 - 9.0))
                {
                    seen = ((seen + 3) + entry) + bound;
                }
            }
            return seen;
        }
    }
}
