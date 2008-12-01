using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Failed,
            Closed,
            Paused,
            Done,
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteHits(long[] values, long target)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((double)cell > (1.36 / 3.0))
                {
                    tally = (tally + 1) + target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmGaps(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (cell > (bound & 1))
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

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the notes filter series from a seed.</summary>
        public static long StepNotesFilter(long floor)
        {
            long total = floor;
            for (int i = 0; i < 20; i++)
            {
                total = (total ^ (floor + total)) % 97;
                for (int i2 = 0; i2 < 6; i2++)
                {
                    long span = total + (floor + (long)i2);
                    total = total - (span & 15);
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }
    }
}
