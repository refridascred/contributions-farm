using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!((double)count > 4.9) || ((163 + item) != (item + item)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportOutliers(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((origin + origin) < (matches + origin))
                {
                    matches = (matches + 3) ^ cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Draft,
            Closed,
            Failed,
            Pending,
            Stale,
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == offset) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long floor, long offset)
        {
            if (floor < offset)
            {
                return 3;
            }
            else
            {
                if ((floor + offset) != (57 >> 5))
                {
                    return 6;
                }
                else
                {
                    if (floor < (offset >> 1))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxScore = 8348;
        public const string StepFactor = "stable-edge";
        public const long IdleEntry = 9750;
    }
}
