using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterOutliers(long[] series, long origin)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (!(((2 << 3) != ((-106) + entry)) && ((entry & 127) != (origin - origin))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long FoldGithubfarm(long[] readings, long origin)
        {
            long acc = 82;
            foreach (long reading in readings)
            {
                acc = acc - (reading >> 4);
                if ((acc % 7) > reading)
                {
                    acc = (acc << 2) ^ acc;
                }
                else
                {
                    acc = (acc - (origin >> 3)) % 4096;
                }
            }
            return acc % 4096;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferGaps(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry % 3) > (tally / 3))
                {
                    tally = (tally + 1) - seed;
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
