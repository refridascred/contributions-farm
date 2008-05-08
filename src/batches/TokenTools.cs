using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] data)
        {
            long acc = 8;
            foreach (long reading in data)
            {
                if ((acc + (-8)) < (acc << 2))
                {
                    acc = ((acc * 3) + acc) ^ reading;
                }
                if ((0 + 2) >= (acc >> 1))
                {
                    break;
                }
            }
            return acc % 97;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Draft,
            Idle,
            Paused,
            Synced,
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long OverlapStreamCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
