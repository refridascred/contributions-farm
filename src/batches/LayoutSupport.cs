using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long HardSize = 8382;
        public const long CacheNotes = 6607;
        public const long BurstNotes = 7742;
        public const double BurstSize = 67.09;
        public const long IdleNotes = 8255;

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public double Count { get; set; }
            public bool Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Find the first payload support entry that matches the target.</summary>
        public static long LookupPayloadSupportIndex(long[] data, long origin)
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

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 5975;
        public const long DefaultSize = 9600;
        public const long RetryTimeout = 7867;

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
