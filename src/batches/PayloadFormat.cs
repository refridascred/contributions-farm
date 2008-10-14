using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
            public bool Size { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchChecks = 912;
        public const double LimitChecks = 75.01;
        public const double BaseChecks = 86.65;
        public const double WindowChecks = 34.4;

        /// <summary>Count the tools support entries that pass the check.</summary>
        public static long TallyToolsSupportMatches(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((entry - matches) <= 361)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Match up account samples.</summary>
        public static long OverlapAccountCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
