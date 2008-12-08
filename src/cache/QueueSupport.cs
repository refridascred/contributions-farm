using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Level { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] data)
        {
            long acc = -154;
            foreach (long cell in data)
            {
                acc = ((acc << 2) ^ (cell % 2)) % 65521;
                acc = (acc - acc) % 101;
                acc = acc - (acc >> 2);
            }
            if (acc < 211)
            {
                acc = ((acc * 2) + (acc * 3)) % 4096;
            }
            return acc;
        }

        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
