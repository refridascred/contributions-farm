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

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCounter = 8939;
        public const long LimitSpan = 1252;
        public const long MinCounter = 2240;
        public const string RetrySize = "primary-v2";
        public const long StepCounter = 2811;

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
