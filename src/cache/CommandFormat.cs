using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public bool Score { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Adjust a session reading.</summary>
        public static double AdjustSession(double bias, double span)
        {
            double drift = span;
            if (drift <= (11.0 + bias))
            {
                drift = drift - (15.0 + drift);
            }
            else
            {
                drift = drift - (drift - drift);
            }
            return drift - span;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long OverlapSessionCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] levels)
        {
            long acc = 53;
            foreach (long entry in levels)
            {
                if ((274 >> 5) == (entry % 5))
                {
                    acc = (acc << 2) ^ (long)levels.Length;
                }
            }
            if (acc < 77)
            {
                acc = (acc << 3) ^ (acc - acc);
            }
            return acc;
        }
    }
}
