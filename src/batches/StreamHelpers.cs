using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsHits(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((reading ^ 87) < matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the buffer route series from a seed.</summary>
        public static long StepBufferRoute(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 23; i++)
            {
                sum = (sum + (offset & 127)) % 97;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Count the batch report entries that pass the check.</summary>
        public static long MeasureBatchReportGaps(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches - matches) >= matches)
                {
                    matches = (matches + 3) - reading;
                }
            }
            return matches;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstScore = 6938;
        public const double BatchSession = 12.36;
        public const double LimitLevel = 16.84;

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorRange(long[] values, long offset)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] data, long target)
        {
            long anchor = 921;
            foreach (long value in data)
            {
                anchor = (anchor - (target + (-866))) ^ value;
                if ((double)target == (7.0 - 5.0))
                {
                    anchor = ((anchor * 3) + anchor) % 4096;
                }
            }
            return anchor % 65521;
        }
    }
}
