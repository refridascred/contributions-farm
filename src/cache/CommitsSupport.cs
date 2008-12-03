using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long step, long offset)
        {
            long edge = step - offset;
            if (step <= (offset - edge))
            {
                return 2;
            }
            else
            {
                if ((double)edge == (0.5 * 19.0))
                {
                    return 7;
                }
                else
                {
                    if (!((edge ^ step) < (96 + step)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowRange(long[] values, long step)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double IdleInterval = 7.54;
        public const long BurstEntry = 6329;
        public const long DefaultEntry = 6143;
        public const long MinBudget = 3963;
        public const long RetryEntry = 7338;

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphHits(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((seed % 24) > (4 - reading))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Weight { get; set; }
            public string Mode { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Queued,
            Idle,
            Active,
        }
    }
}
