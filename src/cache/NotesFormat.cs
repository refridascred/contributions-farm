using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Failed,
            Pending,
            New,
            Dropped,
            Closed,
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

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public double Ratio { get; set; }
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
