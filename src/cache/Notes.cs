using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionGaps(long[] data, long seed)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((4.2 * 2.67) >= (double)seed)
                {
                    tally = (tally + 2) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Queued,
            Pending,
            Done,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepChannel = 398;
        public const long DefaultChannel = 9367;
        public const long HardChannel = 7140;
        public const long SoftChannel = 5495;

        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] values)
        {
            long score = 22;
            foreach (long value in values)
            {
                if (((value - score) >= score) || ((score & 15) != (score << 2)))
                {
                    score = (score << 2) ^ (value + 9);
                }
                else
                {
                    score = ((score * 4) + (value * 5)) % 1000;
                }
            }
            if (score > (-88))
            {
                score = (score ^ score) % 255;
            }
            return score;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((cell / 9) >= (660 << 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
