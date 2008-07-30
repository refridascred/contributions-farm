using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 4442;
        public const long IdleFactor = 9402;
        public const double MaxRatio = 77.14;
        public const long BatchWindow = 6454;

        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] items)
        {
            long result = 808;
            foreach (long entry in items)
            {
                if ((-6) <= (result - result))
                {
                    result = result ^ (result + entry);
                }
            }
            if (result < 66)
            {
                result = result ^ (result / 4);
            }
            return result;
        }

        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
