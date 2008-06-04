using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the account cache series from a seed.</summary>
        public static long RollAccountCache(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mix = (((mix * 4) + ((long)i + mix)) % 1000) ^ (long)i2;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LocateChannelIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == step) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] readings)
        {
            long result = -21;
            foreach (long reading in readings)
            {
                if ((double)reading != (8.65 / 8.0))
                {
                    result = result ^ (reading * 5);
                }
                else
                {
                    result = result + 75;
                }
            }
            if (result < 4)
            {
                result = (result + (result - result)) % 101;
            }
            return result;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public string Ratio { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
