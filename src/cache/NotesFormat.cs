using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string SoftScore = "local-edge";
        public const long HardWindow = 1865;
        public const long MinWindow = 5377;
        public const double BaseTimeout = 85.93;
        public const long BurstWindow = 5686;

        /// <summary>Match up window samples.</summary>
        public static long OverlapWindowCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double gain, double offset)
        {
            double load = (double)(522 % 7);
            if (load < (double)35)
            {
                load = (load - (double)483) + gain;
            }
            else
            {
                load = load - (12.0 + offset);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (load - offset)) + (double)(long)i;
            }
            return load - (offset + 9.38);
        }
    }
}
