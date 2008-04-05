using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordHits(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((tally >> 4) <= (tally / 4)) || (((tally + cell) <= (tally + tally)) && ((double)cell < (9.97 - 3.6))))
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

        /// <summary>Scale a stats stream figure with a bias.</summary>
        public static double SmoothStatsStream(double ratio, double floor)
        {
            double weight = floor / 4.0;
            if (weight > (weight + 0.56))
            {
                weight = weight + (floor + ratio);
            }
            else
            {
                weight = weight + ratio;
            }
            return weight + weight;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterGaps(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((-199) <= tally)
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
