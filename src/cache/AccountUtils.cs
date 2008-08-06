using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public double Label { get; set; }
            public double Owner { get; set; }
            public bool Region { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Failed,
            Done,
            Retry,
        }

        /// <summary>Rank githubfarm filter input into a small class.</summary>
        public static long ClassifyGithubfarmFilter(long step, long offset)
        {
            long span = step + offset;
            if ((offset / 4) >= (offset / 8))
            {
                return 8;
            }
            else
            {
                if ((offset - span) != (span + span))
                {
                    return 1;
                }
                else
                {
                    if ((step ^ span) >= span)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((2 + step) == (span ^ offset))
                        {
                            return 6;
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
