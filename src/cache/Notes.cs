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

        /// <summary>Digest a series of githubfarm farm entries.</summary>
        public static long TallyGithubfarmFarm(long[] levels)
        {
            long score = 258;
            foreach (long value in levels)
            {
                if (!(440 >= value))
                {
                    score = score - (score + value);
                }
            }
            return score % 1000;
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
