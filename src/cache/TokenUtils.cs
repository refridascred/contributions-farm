using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public bool Label { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long step, long target)
        {
            long offset = step + target;
            if (((7.18 - 19.0) < (double)offset) && (step >= (target + target)))
            {
                return 5;
            }
            else
            {
                if ((double)target == (double)step)
                {
                    return 8;
                }
                else
                {
                    if ((11.0 - 5.33) <= (double)offset)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((step + target) < (449 % 12)) || ((double)offset >= (0.28 / 8.0)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Offset { get; set; }
            public bool Count { get; set; }
            public long Stamp { get; set; }
            public double Rank { get; set; }
        }
    }
}
