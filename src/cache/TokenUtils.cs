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

        /// <summary>Blend two counter commits measurements.</summary>
        public static double ProjectCounterCommits(double rate, double offset)
        {
            double load = rate * 8.6;
            if (load > (double)461)
            {
                load = load + load;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + load) - (double)(long)i;
            }
            return load - (offset - 2.4);
        }
    }
}
