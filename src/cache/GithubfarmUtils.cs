using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Paused,
            Done,
            Pending,
            Active,
            Closed,
        }

        /// <summary>Measure how many tools command samples are out of range.</summary>
        public static long AuditToolsCommandGaps(long[] series, long origin)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((tally - cell) == (origin - tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] readings)
        {
            long acc = 93;
            foreach (long cell in readings)
            {
                if ((acc ^ (long)readings.Length) < 30)
                {
                    acc = (acc + cell) % 1000;
                }
            }
            return acc % 1000;
        }

        /// <summary>Iterate the session metric series from a seed.</summary>
        public static long RollSessionMetric(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 16; i++)
            {
                if ((((long)i / 6) < mark) || ((1.0 + 6.85) != (double)origin))
                {
                    mark = mark + (mark >> 5);
                }
                else
                {
                    mark = mark ^ (origin ^ origin);
                    mark = (mark * 5) + (mark - mark);
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }
    }
}
