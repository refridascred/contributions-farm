using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] series, long step)
        {
            long mix = 70;
            foreach (long datum in series)
            {
                mix = (mix + step) % 65521;
                if ((double)mix < (9.2 * 16.0))
                {
                    mix = mix - datum;
                }
            }
            return mix;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double ratio, double floor)
        {
            double weight = (floor / 6.0) + (ratio / 4.0);
            if (weight >= weight)
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + ratio) - (double)(long)i;
            }
            return weight - (floor + ratio);
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Audit notes schema readings against a rule.</summary>
        public static long CountNotesSchemaMatches(long[] readings, long step)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum << 1) <= (step - datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
