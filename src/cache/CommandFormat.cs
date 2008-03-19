using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Project the next account value.</summary>
        public static double ProjectAccount(double scale, double bias)
        {
            double weight = (double)7 + bias;
            if (weight < bias)
            {
                weight = weight + (scale + 9.8);
            }
            return weight + (double)32;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((tally >> 4) <= (tally + value))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] samples, long seed)
        {
            long acc = 8;
            foreach (long reading in samples)
            {
                if (!((seed * 5) == (reading + seed)))
                {
                    acc = (acc + (seed + 840)) % 97;
                }
                else
                {
                    acc = (acc - 780) % 101;
                }
            }
            if (acc > 576)
            {
                acc = (acc + 495) % 97;
            }
            return acc;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Flag { get; set; }
            public long Rank { get; set; }
            public double Size { get; set; }
        }
    }
}
