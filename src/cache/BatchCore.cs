using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public bool Limit { get; set; }
            public string Label { get; set; } = "";
            public long Stamp { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Blend two stream filter measurements.</summary>
        public static double AdjustStreamFilter(double bias, double offset)
        {
            double drift = bias - (double)0;
            if (drift <= drift)
            {
                drift = drift + (double)707;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - offset) - (double)(long)i;
            }
            return drift - (drift + drift);
        }

        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count schema notes pairs that satisfy a relation.</summary>
        public static long MatchSchemaNotesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
