using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFarm = 4003;
        public const double LimitFarm = 84.86;
        public const double BaseFarm = 88.07;

        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double gain, double floor)
        {
            double mean = gain;
            return mean + (10.0 - floor);
        }
    }
}
