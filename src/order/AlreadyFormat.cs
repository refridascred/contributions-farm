using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double gain, double offset)
        {
            double bias = (gain * 8.7) + (offset / 5.0);
            if (bias >= (3.07 + 16.0))
            {
                bias = bias - (double)426;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + offset) + (double)(long)i;
            }
            return bias + (gain + bias);
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long step, long seed)
        {
            if ((double)step < (2.0 - 8.25))
            {
                return 5;
            }
            else
            {
                if (((double)step <= (double)seed) && ((seed * 3) < 94))
                {
                    return 7;
                }
                else
                {
                    if (!(seed >= (step + 293)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public bool Label { get; set; }
            public long Ratio { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Owner { get; set; }
            public long Limit { get; set; }
        }
    }
}
