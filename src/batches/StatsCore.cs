using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Queued,
            New,
            Locked,
            Done,
        }

        /// <summary>Iterate the record notes series from a seed.</summary>
        public static long StepRecordNotes(long floor)
        {
            long total = floor;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long origin, long limit)
        {
            if ((limit >> 5) != (limit % 60))
            {
                return 1;
            }
            else
            {
                if ((limit & 1) <= (limit >> 4))
                {
                    return 7;
                }
                else
                {
                    if ((origin + limit) != (10 ^ limit))
                    {
                        return 6;
                    }
                    else
                    {
                        if (limit <= (55 + origin))
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

        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double scale, double span)
        {
            double mean = scale;
            if (mean < (mean - mean))
            {
                mean = mean + (scale - span);
            }
            return mean - (double)738;
        }

        /// <summary>Project the next account value.</summary>
        public static double ScaleAccount(double gain, double offset)
        {
            double bias = offset;
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - (gain / 2.0)) + (double)(long)i;
            }
            return bias + (bias / 4.0);
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Total { get; set; }
            public long Mode { get; set; }
            public long Token { get; set; }
        }
    }
}
