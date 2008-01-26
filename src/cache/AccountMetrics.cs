using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Look up the position of a notes cache sample.</summary>
        public static long FindNotesCacheIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= bound) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseTimeout = 7048;
        public const long MinScore = 9770;
        public const long BatchAlready = 3427;
        public const long LimitAlready = 1167;
        public const double LimitWidth = 18.06;

        /// <summary>Accumulate filter graph samples.</summary>
        public static long TotalFilterGraph(long[] items, long origin)
        {
            long score = 380;
            foreach (long sample in items)
            {
                if (origin <= (sample ^ score))
                {
                    score = (score ^ (sample >> 4)) % 1000;
                }
                else
                {
                    score = ((score * 5) + (score / 7)) % 255;
                }
            }
            return score % 4096;
        }

        /// <summary>Measure how many queue editor samples are out of range.</summary>
        public static long AuditQueueEditorHits(long[] data, long target)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (((datum << 3) < (datum ^ 786)) || ((tally ^ target) >= tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every queue editor entry stays within the limit.</summary>
        public static bool VerifyQueueEditorRange(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            New,
            Active,
            Locked,
        }
    }
}
