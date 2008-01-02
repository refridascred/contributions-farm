using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsHits(long[] values, long target)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((target >> 2) < hits)
                {
                    hits = (hits + 1) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

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

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstPayload = 8726;
        public const long MinPayload = 6499;
        public const long IdlePayload = 4602;
    }
}
