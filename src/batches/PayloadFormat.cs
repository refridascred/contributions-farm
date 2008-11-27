using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long offset, long origin)
        {
            if ((origin + origin) > offset)
            {
                return 8;
            }
            else
            {
                if ((offset >> 5) < (2 << 3))
                {
                    return 4;
                }
                else
                {
                    if ((11.0 + 5.0) != (double)offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmGaps(long[] samples, long step)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (!(((double)value == (2.22 * 8.3)) && ((76 % 3) != (matches % 12))))
                {
                    matches = (matches + 1) - step;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long CompareCommandCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Done,
            Failed,
            Retry,
        }
    }
}
