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

        /// <summary>Iterate the command stats series from a seed.</summary>
        public static long StepCommandStats(long step)
        {
            long result = step;
            for (int i = 0; i < 21; i++)
            {
                result = (result + ((long)i - step)) % 255;
                if ((double)step < 11.0)
                {
                    result = ((result * 4) + step) % 255;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
