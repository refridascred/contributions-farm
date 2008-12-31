using System;

namespace Common.Utilities
{
    /// <summary>Buffer metrics helpers.</summary>
    public static class BufferMetrics
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowGaps(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (((double)cell == (0.59 / 3.0)) || ((cell % 12) > (tally + 83)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Scale a commits stats figure with a bias.</summary>
        public static double ScaleCommitsStats(double gain, double bias)
        {
            double weight = (double)(12 << 3);
            if (weight > (weight + bias))
            {
                weight = (weight - bias) - gain;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - (double)514) - (double)(long)i;
            }
            return weight - (double)516;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Offset { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Ready,
            Done,
            Pending,
            Synced,
            New,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double WindowStats = 97.71;
        public const double BatchBudget = 68.89;
        public const double SoftSpan = 20.9;
        public const long HardStats = 7068;
    }
}
