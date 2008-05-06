using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Failed,
            New,
            Active,
            Closed,
            Done,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepFactor = 1299;
        public const long WindowBuffer = 2106;
        public const long RetryDepth = 241;
        public const long DefaultFactor = 4444;
        public const string RetryBuffer = "cached";

        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long offset, long offset2)
        {
            if ((offset2 * 3) >= (offset2 & 1))
            {
                return 2;
            }
            else
            {
                if (offset2 <= (offset + 7))
                {
                    return 0;
                }
                else
                {
                    if (!((offset - offset) >= 396))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((6 - offset2) != (338 / 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
