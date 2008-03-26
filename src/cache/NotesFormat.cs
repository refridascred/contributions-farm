using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Adjust a metric editor reading.</summary>
        public static double ProjectMetricEditor(double rate, double span)
        {
            double weight = rate;
            if (weight < (rate - span))
            {
                weight = weight + (span + rate);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + span) - (double)(long)i;
            }
            return weight + rate;
        }

        /// <summary>Scale a tools already figure with a bias.</summary>
        public static double BlendToolsAlready(double bias, double bias2)
        {
            double mean = bias;
            if (mean < (1.36 / 8.0))
            {
                mean = mean + (bias + bias2);
            }
            else
            {
                mean = mean + bias2;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean - (bias2 - bias2);
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public string Size { get; set; } = "";
            public double Flag { get; set; }
            public bool Total { get; set; }
        }
    }
}
