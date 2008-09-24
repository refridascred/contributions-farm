using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Match up profile record samples.</summary>
        public static long CompareProfileRecordCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] items)
        {
            long anchor = 36;
            foreach (long reading in items)
            {
                if ((2.8 / 6.0) > (double)reading)
                {
                    anchor = ((anchor * 4) + (anchor << 3)) % 4096;
                    break;
                }
                anchor = (anchor ^ (anchor & 31)) % 1000;
                anchor = (anchor + (reading / 7)) % 65521;
            }
            return anchor;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 8644;
        public const long HardGraph = 8602;
        public const long BatchRatio = 6168;
        public const string SoftGraph = "primary-edge";
        public const long RetryGraph = 3118;
    }
}
