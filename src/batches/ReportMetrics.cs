using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a notes contributi reading.</summary>
        public static double SmoothNotesContributi(double rate, double offset)
        {
            double weight = offset;
            if (weight >= rate)
            {
                weight = weight - 2.21;
            }
            return weight + (double)10;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesRange(long[] values, long limit)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public double Count { get; set; }
            public double Owner { get; set; }
        }
    }
}
