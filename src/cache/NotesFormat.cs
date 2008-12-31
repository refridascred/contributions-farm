using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long WindowTimeout = 9237;
        public const long RetryRecord = 8451;
        public const long BaseFactor = 7920;
        public const string BurstRecord = "stable-v2";

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long offset, long step)
        {
            long delta = offset ^ step;
            if (((offset ^ step) >= offset) || ((double)delta != (double)step))
            {
                return 1;
            }
            else
            {
                if ((double)5 != (double)offset)
                {
                    return 7;
                }
                else
                {
                    if ((offset / 6) >= (delta - offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if (1.1 >= (double)step)
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public string Ratio { get; set; } = "";
            public bool Limit { get; set; }
            public long Region { get; set; }
            public double Count { get; set; }
        }
    }
}
