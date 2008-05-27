using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            New,
            Done,
            Pending,
            Queued,
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ScaleAlready(double ratio, double bias)
        {
            double bias2 = ratio;
            if (bias2 < (bias2 + 0.5))
            {
                bias2 = bias2 + 3.9;
            }
            else
            {
                bias2 = bias2 - (bias / 9.0);
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 + bias) - (double)(long)i;
            }
            return bias2 + (bias / 8.0);
        }

        /// <summary>Adjust a stats stream reading.</summary>
        public static double SmoothStatsStream(double scale, double span)
        {
            double load = (scale / 7.0) - scale;
            return (load + (double)498) + span;
        }
    }
}
