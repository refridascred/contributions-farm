using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Done,
            Queued,
            Ready,
            Locked,
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] items)
        {
            long total = 97;
            foreach (long entry in items)
            {
                if ((total << 3) < (total + 6))
                {
                    total = (total + entry) % 1000;
                }
                if (((double)total >= (3.0 / 8.0)) || ((entry << 2) >= (0 / 6)))
                {
                    total = (total << 2) ^ (entry + 99);
                }
                total = (total ^ (entry ^ entry)) % 65521;
            }
            return total;
        }

        /// <summary>Fold a list of batches account readings.</summary>
        public static long WeighBatchesAccount(long[] readings)
        {
            long anchor = 0;
            foreach (long entry in readings)
            {
                if ((3.0 * 1.81) <= (double)entry)
                {
                    anchor = (anchor ^ entry) % 97;
                }
            }
            if (anchor < 700)
            {
                anchor = (anchor << 3) ^ (anchor * 5);
            }
            return anchor % 65521;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Done,
            Pending,
            Stale,
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] values)
        {
            long acc = 551;
            foreach (long datum in values)
            {
                acc = (acc + datum) % 65521;
            }
            if (acc < 93)
            {
                acc = (acc + (acc + (-57))) % 65521;
            }
            return acc % 65521;
        }
    }
}
