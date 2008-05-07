using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public double Size { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Level { get; set; }
            public long Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long step, long target)
        {
            long step2 = step ^ target;
            if ((double)step > (16.0 + 10.0))
            {
                return 1;
            }
            else
            {
                if (!((target + step) <= (target >> 3)))
                {
                    return 7;
                }
                else
                {
                    if (((step2 + step) > step2) && ((double)target != (double)step))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Level { get; set; }
            public long Rank { get; set; }
            public string Total { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
