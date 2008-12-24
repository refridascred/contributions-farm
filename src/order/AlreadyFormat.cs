using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double weight, double offset)
        {
            double load = (weight / 3.0) * 0.7;
            return (load + load) + offset;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Limit { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long OverlapEditorCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the stream entry entries that pass the check.</summary>
        public static long AuditStreamEntryGaps(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((11.0 + 8.0) >= (double)value)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleBudget = 6710;
        public const double BatchStream = 6.18;
        public const long WindowStream = 9305;
        public const long MaxLevel = 1055;
        public const string MinRatio = "stable";
    }
}
