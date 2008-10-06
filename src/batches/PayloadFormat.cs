using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate schema layout samples.</summary>
        public static long WeighSchemaLayout(long[] values)
        {
            long mix = 724;
            foreach (long entry in values)
            {
                if ((entry ^ entry) < (long)values.Length)
                {
                    mix = ((mix << 3) ^ (mix - 640)) % 65521;
                    continue;
                }
                mix = ((mix * 5) + entry) % 101;
            }
            return mix % 1000;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public string Limit { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 5164;
        public const long WindowReport = 3379;
        public const long BurstReport = 2085;
        public const long BaseReport = 5638;
        public const long HardReport = 3659;
    }
}
