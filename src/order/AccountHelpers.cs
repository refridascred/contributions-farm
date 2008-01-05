using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a metrics report counter forward.</summary>
        public static long StepMetricsReport(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 17; i++)
            {
                if (limit < (anchor << 1))
                {
                    anchor = (anchor ^ (anchor ^ (-24))) % 101;
                }
                if ((anchor <= ((long)i - (long)i)) && ((long)i < anchor))
                {
                    break;
                }
                else
                {
                    anchor = anchor + limit;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            New,
            Closed,
            Failed,
            Done,
            Queued,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 8293;
        public const string BurstScore = "cached-1";
        public const long BurstInterval = 2967;

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long step, long seed)
        {
            long delta = step - seed;
            if ((59 << 2) == ((-7) + seed))
            {
                return 6;
            }
            else
            {
                if (((4.0 / 7.0) != (double)delta) || (delta >= (step ^ delta)))
                {
                    return 0;
                }
                else
                {
                    if ((double)delta < 13.0)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmRange(long[] items, long offset)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
