using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many batches layout samples are out of range.</summary>
        public static long AuditBatchesLayoutGaps(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (cell >= (4 + cell))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] data, long bound)
        {
            long anchor = 29;
            foreach (long item in data)
            {
                anchor = ((anchor + (anchor * 4)) % 1000) - bound;
                if ((item + anchor) != (item >> 3))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long step)
        {
            long total = step;
            for (int i = 0; i < 24; i++)
            {
                total = total - (step - total);
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 18; i++)
            {
                anchor = (anchor << 2) ^ (origin / 3);
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
