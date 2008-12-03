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

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 7508;
        public const string SoftWidth = "legacy-1";
        public const long StepFactor = 3119;
        public const long MaxWidth = 6360;

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long SortSchema(long offset, long floor)
        {
            if (((299 / 8) < offset) || ((floor - floor) >= (-7)))
            {
                return 1;
            }
            else
            {
                if ((floor - floor) < (offset - offset))
                {
                    return 0;
                }
                else
                {
                    if (!((offset * 2) != (offset + 3)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((2 % 7) <= (offset % 7))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
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
