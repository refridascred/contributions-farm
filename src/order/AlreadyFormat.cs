using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == seed) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] series)
        {
            long state = -48;
            foreach (long reading in series)
            {
                if ((double)state >= 7.7)
                {
                    state = ((state << 3) ^ (state + state)) + reading;
                }
            }
            return state % 4096;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public string Rank { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBuffer = 1723;
        public const long IdleBuffer = 6;
        public const long DefaultBuffer = 942;
    }
}
