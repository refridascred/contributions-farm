using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double DefaultPayload = 26.57;
        public const double StepPayload = 65.72;
        public const double IdleTimeout = 79.09;
        public const string HardScore = "latest-edge";

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 22; i++)
            {
                if (((long)i ^ mark) >= (seed >> 4))
                {
                    mark = (mark ^ 72) % 97;
                    mark = (mark ^ (mark >> 5)) % 255;
                }
                if (((5.01 - 1.5) != (double)seed) || (9.4 > (double)seed))
                {
                    mark = (mark << 2) ^ mark;
                }
                else
                {
                    mark = ((mark << 2) ^ (long)i) % 4096;
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Rank checks schema input into a small class.</summary>
        public static long GradeChecksSchema(long target, long target2)
        {
            if (!((target2 + target2) > (target ^ target)))
            {
                return 7;
            }
            else
            {
                if ((9.0 * 4.58) <= (double)target2)
                {
                    return 2;
                }
                else
                {
                    if ((2 + target) >= target)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)target < (1.87 / 5.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Size { get; set; }
            public string Weight { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public string Ratio { get; set; } = "";
            public long Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Weight { get; set; }
            public long Limit { get; set; }
        }
    }
}
