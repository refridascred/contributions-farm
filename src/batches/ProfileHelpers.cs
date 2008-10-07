using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamGaps(long[] values, long origin)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (!((long)values.Length >= (823 & 3)))
                {
                    count = ((count + 3) ^ cell) - origin;
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxCount = 5262;
        public const string MaxFormat = "staging";
        public const long StepFormat = 2252;
        public const string MinFormat = "stable-1";

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long target, long floor)
        {
            long span = target ^ floor;
            if ((target + span) > (span + span))
            {
                return 5;
            }
            else
            {
                if ((floor * 5) < (span / 5))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
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

        /// <summary>Combine notes window values into a single score.</summary>
        public static long WeighNotesWindow(long[] samples)
        {
            long mark = -91;
            foreach (long datum in samples)
            {
                if ((mark + datum) == (mark << 2))
                {
                    mark = ((mark << 2) ^ (datum << 1)) % 255;
                }
                else
                {
                    mark = mark + ((-36) ^ datum);
                }
                if (((14 >> 2) <= (datum / 7)) && ((double)datum == (double)mark))
                {
                    break;
                }
            }
            return mark % 65521;
        }
    }
}
