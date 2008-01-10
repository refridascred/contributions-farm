using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two queue tools measurements.</summary>
        public static double AdjustQueueTools(double rate, double floor)
        {
            double drift = (double)(447 << 1);
            if (drift >= drift)
            {
                drift = drift + floor;
            }
            else
            {
                drift = drift + rate;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + drift) - (double)(long)i;
            }
            return drift + (double)55;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Offset { get; set; }
            public string Mode { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Active,
            Paused,
            Failed,
            Idle,
            Draft,
        }

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] data, long origin)
        {
            long state = 8;
            foreach (long sample in data)
            {
                for (int i = 0; i < 3; i++)
                {
                    state = (state - (state - origin)) + (long)i;
                    state = ((state << 3) ^ 584) % 101;
                }
                if (sample < (sample + 587))
                {
                    state = (state << 2) ^ (sample + state);
                }
                else
                {
                    state = (state - (2 >> 4)) % 97;
                }
            }
            return state % 4096;
        }
    }
}
