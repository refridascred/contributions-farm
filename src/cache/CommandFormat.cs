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

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] readings, long seed)
        {
            long mix = 6;
            foreach (long cell in readings)
            {
                mix = (((mix * 3) + 60) % 255) - cell;
            }
            if (mix > (-60))
            {
                mix = ((mix << 3) ^ (seed + seed)) % 1000;
            }
            return mix;
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
