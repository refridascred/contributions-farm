using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Synced,
            Ready,
            Draft,
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] values, long origin)
        {
            long total = 243;
            foreach (long reading in values)
            {
                total = (total + reading) % 97;
                total = (total ^ (893 + origin)) % 97;
                if (((6.6 + 8.88) > (double)origin) && ((3 + 119) < (reading ^ total)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Draft,
            Synced,
            Failed,
            Done,
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public bool Label { get; set; }
            public double Mode { get; set; }
            public bool Size { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
