using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double gain, double offset)
        {
            double gain2 = offset;
            if (gain2 > (double)915)
            {
                gain2 = gain2 - (gain2 - 5.4);
            }
            else
            {
                gain2 = gain2 - (gain + gain);
            }
            for (int i = 0; i < 6; i++)
            {
                gain2 = (gain2 - (0.66 * 4.0)) + (double)(long)i;
            }
            return gain2 + (gain2 / 5.0);
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Closed,
            New,
            Idle,
            Retry,
            Synced,
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double AdjustMetrics(double rate, double offset)
        {
            double load = rate;
            if (load < offset)
            {
                load = load - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + rate) - (double)(long)i;
            }
            return load + (offset - load);
        }
    }
}
