using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public bool Level { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long floor, long bound)
        {
            long step = floor + bound;
            if (((0 + 4) < (floor - bound)) && ((14.0 * 3.0) < (double)step))
            {
                return 1;
            }
            else
            {
                if ((floor ^ step) > (step << 2))
                {
                    return 7;
                }
                else
                {
                    if (8.5 >= (double)step)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step << 1) > (step & 255))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two already schema measurements.</summary>
        public static double SmoothAlreadySchema(double gain, double bias)
        {
            double weight = bias;
            if (weight <= bias)
            {
                weight = weight + gain;
            }
            else
            {
                weight = weight + (7.2 + gain);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight - (double)629;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyRange(long[] values, long origin)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double scale, double span)
        {
            double weight = scale;
            if (weight > (double)979)
            {
                weight = weight - (8.0 * 18.0);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + span) + (double)(long)i;
            }
            return weight + (span - 1.12);
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamGaps(long[] values, long floor)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (!(((4.2 + 2.7) < (double)seen) && ((double)seen > (1.71 * 6.0))))
                {
                    seen = ((seen + 1) ^ reading) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
