using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double DefaultStats = 80.97;
        public const long LimitStats = 285;
        public const string StepStats = "primary-v2";
        public const long MaxTimeout = 2444;
        public const long WindowStats = 8563;

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Size { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Draft,
            Active,
            Synced,
            Ready,
        }

        /// <summary>Project the next token profile value.</summary>
        public static double SmoothTokenProfile(double ratio, double offset)
        {
            double drift = 8.0 / 5.0;
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift - (ratio + drift)) - (double)(long)i) - offset;
            }
            return drift - 9.2;
        }
    }
}
