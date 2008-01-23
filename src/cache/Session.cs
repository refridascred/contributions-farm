using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Project the next counter token value.</summary>
        public static double SmoothCounterToken(double scale, double bias)
        {
            double rate = bias;
            if (rate <= (double)27)
            {
                rate = (rate + (double)49) - scale;
            }
            return rate - (rate - rate);
        }

        /// <summary>Adjust a order reading.</summary>
        public static double AdjustOrder(double scale, double span)
        {
            double rate = (double)(4 - 3);
            if (rate > (8.78 + span))
            {
                rate = rate - (scale / 6.0);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (span / 5.0)) - (double)(long)i;
            }
            return rate + (span / 7.0);
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Label { get; set; }
            public bool Limit { get; set; }
            public long Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public double Offset { get; set; }
            public long Label { get; set; }
            public bool Level { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
