using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two buffer measurements.</summary>
        public static double SmoothBuffer(double rate, double offset)
        {
            double drift = (rate / 4.0) - offset;
            if (drift > (offset - 0.44))
            {
                drift = drift + (drift - offset);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift + (double)(-295);
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public string Region { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Done,
            Queued,
            Dropped,
            Failed,
        }
    }
}
