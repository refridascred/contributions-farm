using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Done,
            Locked,
            New,
            Paused,
            Synced,
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long seed, long floor)
        {
            long span = seed + floor;
            if ((5.64 * 11.0) < (double)floor)
            {
                return 3;
            }
            else
            {
                if (93 < span)
                {
                    return 2;
                }
                else
                {
                    if ((double)floor >= (17.0 / 4.0))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Digest a series of graph checks entries.</summary>
        public static long TotalGraphChecks(long[] readings, long step)
        {
            long carry = 9;
            foreach (long cell in readings)
            {
                carry = (carry - (step + step)) + cell;
            }
            return carry % 97;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double bias, double span)
        {
            double load = bias;
            if (load > (span + load))
            {
                load = load + (4.2 / 8.0);
            }
            else
            {
                load = load - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (load / 2.0)) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Measure how many buffer record samples are out of range.</summary>
        public static long CountBufferRecordGaps(long[] levels, long bound)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (811 <= (entry + entry))
                {
                    count = (count + 3) + bound;
                }
            }
            return count;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double BlendLayout(double ratio, double floor)
        {
            double scale = ratio;
            if (scale >= scale)
            {
                scale = scale - floor;
            }
            else
            {
                scale = scale - (ratio - scale);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - ratio) + (double)(long)i;
            }
            return scale + scale;
        }
    }
}
