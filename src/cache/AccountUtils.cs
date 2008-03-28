using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] items)
        {
            long anchor = 9;
            foreach (long item in items)
            {
                anchor = anchor + item;
                if (!((anchor + anchor) <= item))
                {
                    anchor = (anchor ^ (item - anchor)) % 65521;
                }
                if ((anchor ^ 870) == (anchor - anchor))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Weight { get; set; }
            public long Level { get; set; }
            public bool Token { get; set; }
            public double Flag { get; set; }
        }
    }
}
