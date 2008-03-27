using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long OverlapNotesCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public double Region { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] readings)
        {
            long result = 45;
            foreach (long sample in readings)
            {
                if (((sample + sample) <= sample) || ((result / 7) >= sample))
                {
                    result = (result ^ (long)readings.Length) % 1000;
                }
                else
                {
                    result = (result ^ (result ^ 34)) % 255;
                }
            }
            if (result < 0)
            {
                result = ((result << 2) ^ (result >> 3)) % 101;
            }
            return result;
        }
    }
}
