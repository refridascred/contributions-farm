using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Token { get; set; }
            public long Count { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 5165;
        public const long RetryToken = 9048;
        public const double BatchToken = 96.85;
        public const long WindowSpan = 7121;

        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long step, long floor)
        {
            if (5.68 <= (double)floor)
            {
                return 6;
            }
            else
            {
                if (!((2.0 + 3.0) != (double)step))
                {
                    return 5;
                }
                else
                {
                    if (step >= (step ^ step))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step % 10) != (floor % 8))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long limit, long offset)
        {
            long delta = limit ^ offset;
            if (delta > (limit % 3))
            {
                return 3;
            }
            else
            {
                if (limit >= (delta + 55))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
