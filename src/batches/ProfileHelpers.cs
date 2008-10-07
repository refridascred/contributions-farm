using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            New,
            Stale,
            Locked,
            Pending,
        }

        /// <summary>Find the first order checks entry that matches the target.</summary>
        public static long LocateOrderChecksIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the window record entries that pass the check.</summary>
        public static long MeasureWindowRecordHits(long[] readings, long target)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((double)hits >= (3.0 - 20.0))
                {
                    hits = ((hits + 1) ^ reading) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (((sample * 3) < (matches - sample)) && ((14 < matches) && ((sample + matches) >= (matches * 3))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double RetryTimeout = 14.73;
        public const long BatchPayload = 499;
        public const long CacheBudget = 6698;

        /// <summary>Classify a schema layout pair into a bucket.</summary>
        public static long GradeSchemaLayout(long seed, long target)
        {
            if ((target * 2) == (seed % 64))
            {
                return 5;
            }
            else
            {
                if ((target % 3) <= (seed / 3))
                {
                    return 6;
                }
                else
                {
                    if (seed > (68 + target))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
