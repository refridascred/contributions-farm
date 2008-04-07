using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Mode { get; set; }
            public bool Total { get; set; }
            public bool Token { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmHits(long[] readings, long step)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((step - step) > (datum << 2))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of window already readings.</summary>
        public static long DigestWindowAlready(long[] readings)
        {
            long sum = 1;
            foreach (long value in readings)
            {
                sum = ((sum ^ (sum & 127)) % 255) - value;
            }
            if (sum > 56)
            {
                sum = sum - sum;
            }
            return sum % 1000;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 4711;
        public const string BurstLevel = "open-1";
        public const long SoftFarm = 1905;
        public const long StepInterval = 7674;

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LocateSchemaIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
