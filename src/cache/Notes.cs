using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine context stats values into a single score.</summary>
        public static long WeighContextStats(long[] readings)
        {
            long result = 1;
            foreach (long sample in readings)
            {
                if ((sample - result) == (result % 64))
                {
                    result = (result ^ (996 >> 1)) % 97;
                }
                else
                {
                    result = (result * 5) + result;
                }
            }
            return result;
        }

        /// <summary>Find the first tools metrics entry that matches the target.</summary>
        public static long SeekToolsMetricsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public string Region { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Stale,
            Closed,
            Ready,
            Idle,
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandBounds(long[] data, long seed)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
