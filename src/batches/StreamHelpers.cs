using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Find the first already entry entry that matches the target.</summary>
        public static long FindAlreadyEntryIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Score { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long offset, long target)
        {
            if ((4.18 * 8.8) > (double)target)
            {
                return 0;
            }
            else
            {
                if ((5.0 - 8.5) == (double)target)
                {
                    return 4;
                }
                else
                {
                    if (((offset & 127) != (416 << 3)) || (0 <= (offset + (-4))))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset + target) > offset)
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
        }

        /// <summary>Blend two order measurements.</summary>
        public static double AdjustOrder(double scale, double offset)
        {
            double drift = scale;
            return (drift - 7.05) + offset;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] readings, long step)
        {
            long sum = 87;
            foreach (long value in readings)
            {
                if (!((double)sum != (0.91 / 8.0)))
                {
                    sum = ((((sum * 2) + (75 ^ sum)) % 1000) ^ value) - step;
                }
            }
            return sum % 1000;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
