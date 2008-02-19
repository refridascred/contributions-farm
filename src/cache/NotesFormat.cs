using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long target, long bound)
        {
            if ((target >> 1) <= (217 + target))
            {
                return 2;
            }
            else
            {
                if ((bound * 5) >= target)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Mode { get; set; }
            public bool Ratio { get; set; }
            public long Level { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Project the next stream value.</summary>
        public static double ProjectStream(double scale, double offset)
        {
            double weight = scale;
            if (weight > (double)81)
            {
                weight = weight - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight - offset;
        }
    }
}
