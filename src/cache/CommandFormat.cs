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

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleWidth = 8403;
        public const double DefaultFormat = 8.9;
        public const long StepInterval = 6124;

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

        /// <summary>Iterate the window series from a seed.</summary>
        public static long StepWindow(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
