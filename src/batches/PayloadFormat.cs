using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long SeekChannelIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long MatchFilterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of payload editor entries.</summary>
        public static long TotalPayloadEditor(long[] samples)
        {
            long result = 822;
            foreach (long sample in samples)
            {
                if ((5 - (-8)) == (result ^ sample))
                {
                    result = (result - sample) % 97;
                }
            }
            if (result > 43)
            {
                result = (result - ((-8) & 63)) % 65521;
            }
            return result;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Label { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
