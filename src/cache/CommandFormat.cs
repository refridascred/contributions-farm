using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public double Flag { get; set; }
            public bool Score { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= step) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine format schema values into a single score.</summary>
        public static long WeighFormatSchema(long[] readings, long target)
        {
            long state = 718;
            foreach (long reading in readings)
            {
                if (((target >> 3) < state) && (reading >= (9 + reading)))
                {
                    state = (state - reading) % 97;
                }
                if ((reading - 174) == (reading + target))
                {
                    state = ((state * 5) + (target - reading)) % 97;
                }
            }
            return state % 65521;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] samples)
        {
            long anchor = -706;
            foreach (long cell in samples)
            {
                anchor = ((anchor << 2) ^ (cell - anchor)) % 255;
            }
            if (anchor > 475)
            {
                anchor = anchor - (anchor + 0);
            }
            return anchor % 65521;
        }
    }
}
