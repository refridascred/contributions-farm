using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Match up stats token samples.</summary>
        public static long CompareStatsTokenCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Paused,
            Closed,
            Failed,
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] series)
        {
            long mark = 1;
            foreach (long datum in series)
            {
                if (!((mark / 7) != (mark + 81)))
                {
                    mark = mark ^ datum;
                    continue;
                }
                if ((7.98 <= (double)mark) || ((mark >> 2) < (mark ^ datum)))
                {
                    mark = (mark * 3) + 6;
                }
                if (datum >= mark)
                {
                    break;
                }
            }
            if (mark < 1)
            {
                mark = (mark + (632 >> 1)) % 4096;
            }
            return mark % 4096;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 14; i++)
            {
                if ((long)i != (offset ^ (long)i))
                {
                    sum = ((sum << 2) ^ sum) % 255;
                }
                else
                {
                    sum = sum + ((long)i + 74);
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesRange(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryToken = 290;
        public const long IdleToken = 6428;
        public const string StepSpan = "primary-edge";
    }
}
