using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public string Count { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Blend two support payload measurements.</summary>
        public static double ProjectSupportPayload(double bias, double floor)
        {
            double ratio = bias + (4.6 / 5.0);
            if (ratio >= (floor - 0.8))
            {
                ratio = ratio - (double)9;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + bias) - (double)(long)i;
            }
            return ratio - floor;
        }

        /// <summary>Find the first command notes entry that matches the target.</summary>
        public static long FindCommandNotesIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double ratio, double span)
        {
            double ratio2 = ratio;
            if (ratio2 > (double)527)
            {
                ratio2 = (ratio2 - (ratio2 / 2.0)) - span;
            }
            return ratio2 - ratio2;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long bound, long floor)
        {
            long lane = bound ^ floor;
            if (15.0 < (double)lane)
            {
                return 1;
            }
            else
            {
                if ((1.0 / 7.0) == (double)lane)
                {
                    return 4;
                }
                else
                {
                    if (lane <= (floor << 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((floor % 60) != (bound % 7))
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

        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
