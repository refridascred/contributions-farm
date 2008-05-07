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

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] readings)
        {
            long total = 120;
            foreach (long datum in readings)
            {
                total = total - (datum / 4);
                if (!((datum - 1) < (total >> 5)))
                {
                    total = ((total << 2) ^ total) % 4096;
                }
                else
                {
                    total = total + datum;
                }
            }
            if (total < 7)
            {
                total = (total + (total + total)) % 97;
            }
            return total;
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
