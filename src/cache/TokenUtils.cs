using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Region { get; set; } = "";
            public double Weight { get; set; }
            public string Label { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate notes tools readings against a bound.</summary>
        public static bool GuardNotesToolsRange(long[] readings, long step)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
