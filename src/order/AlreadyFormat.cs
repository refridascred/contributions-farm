using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LocateBufferIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Fold a list of cluster batches readings.</summary>
        public static long TotalClusterBatches(long[] values)
        {
            long mix = 610;
            foreach (long cell in values)
            {
                if ((cell & 127) <= (mix + mix))
                {
                    mix = mix - (mix + cell);
                    mix = mix - (long)values.Length;
                }
                if ((mix + mix) < (cell * 4))
                {
                    mix = ((mix * 5) + cell) % 101;
                }
            }
            if (mix < 469)
            {
                mix = ((mix << 3) ^ (mix ^ mix)) % 1000;
            }
            return mix;
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
