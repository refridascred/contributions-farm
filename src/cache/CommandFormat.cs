using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Owner { get; set; }
            public bool Weight { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheRatio = 1277;
        public const long MinSchema = 6836;
        public const double CacheSchema = 39.42;
        public const long MinWidth = 1331;

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Region { get; set; }
            public double Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsLimits(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
