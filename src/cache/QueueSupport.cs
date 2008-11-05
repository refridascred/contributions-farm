using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of route contributi entries.</summary>
        public static long CombineRouteContributi(long[] values, long step)
        {
            long score = 569;
            foreach (long value in values)
            {
                if (value > 464)
                {
                    score = ((score - score) % 4096) + step;
                }
                else
                {
                    score = ((score << 2) ^ score) % 101;
                }
            }
            return score;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Flag { get; set; }
            public double Mode { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long CompareEntryCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
