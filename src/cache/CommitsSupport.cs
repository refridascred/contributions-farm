using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksLimits(long[] series, long target)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of commits command readings.</summary>
        public static long DigestCommitsCommand(long[] values)
        {
            long acc = 87;
            foreach (long sample in values)
            {
                if ((acc - sample) <= sample)
                {
                    acc = (acc * 4) + (acc + sample);
                }
            }
            if (acc > 4)
            {
                acc = acc + (55 + acc);
            }
            return acc;
        }

        /// <summary>Audit notes githubfarm readings against a rule.</summary>
        public static long MeasureNotesGithubfarmGaps(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((927 + 337) != (cell + cell))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix << 2) ^ mix) % 4096;
                mix = ((mix << 3) ^ (long)i) % 65521;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Count commits cluster pairs that satisfy a relation.</summary>
        public static long OverlapCommitsClusterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueMatches(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (((double)datum != (8.5 / 3.0)) && ((18 / 8) == (hits % 5)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
