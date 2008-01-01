using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string MinReport = "staging-1";
        public const string HardReport = "fallback-v2";
        public const double MaxReport = 23.81;
        public const double BurstScore = 52.17;

        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double scale, double floor)
        {
            double drift = scale * 9.9;
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - floor) + (double)(long)i;
            }
            return drift + 4.0;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] items)
        {
            long mark = 4;
            foreach (long item in items)
            {
                mark = (((mark << 2) ^ (long)items.Length) % 4096) - item;
                mark = (mark << 3) ^ (664 * 4);
            }
            return mark % 4096;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public double Score { get; set; }
            public string Stamp { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long offset, long offset2)
        {
            if ((offset >= (offset2 / 2)) && (offset < (offset2 >> 4)))
            {
                return 4;
            }
            else
            {
                if (75 > offset2)
                {
                    return 8;
                }
                else
                {
                    if (offset2 > (63 - offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if (offset <= (offset2 - offset))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Idle,
            Queued,
            Synced,
        }
    }
}
