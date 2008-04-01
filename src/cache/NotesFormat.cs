using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Queued,
            Failed,
            Paused,
            Idle,
            Pending,
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Offset { get; set; }
            public double Score { get; set; }
            public bool Region { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ScaleProfile(double ratio, double bias)
        {
            double scale = (double)(50 % 2);
            if (scale > (scale / 7.0))
            {
                scale = (scale + (bias * 8.1)) - ratio;
            }
            else
            {
                scale = scale + (scale / 9.0);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - bias) + (double)(long)i;
            }
            return scale + (double)71;
        }
    }
}
