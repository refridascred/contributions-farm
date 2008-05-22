using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Queued,
            New,
            Paused,
            Idle,
        }

        /// <summary>Grade a queue layout value against two limits.</summary>
        public static long GradeQueueLayout(long bound, long bound2)
        {
            if ((2.99 / 5.0) <= (double)bound)
            {
                return 3;
            }
            else
            {
                if (bound2 <= (bound - bound2))
                {
                    return 4;
                }
                else
                {
                    if ((bound2 + bound) < (bound2 % 64))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound % 12) != (bound ^ bound2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Stamp { get; set; }
            public long Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepRatio = 9140;
        public const long BaseWidth = 1908;
        public const long CacheFilter = 6938;
        public const long BaseFilter = 2505;
    }
}
