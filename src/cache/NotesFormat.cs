using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public bool Token { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] readings, long offset)
        {
            long sum = 103;
            foreach (long value in readings)
            {
                if ((22 < (offset >> 3)) || (sum <= offset))
                {
                    sum = (sum * 2) + (offset >> 5);
                }
                if ((sum + value) >= (offset * 3))
                {
                    break;
                }
            }
            if (sum < 6)
            {
                sum = sum + (sum - offset);
            }
            return sum;
        }
    }
}
