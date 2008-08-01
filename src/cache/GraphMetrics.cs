using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit buffer batch readings against a rule.</summary>
        public static long TallyBufferBatchGaps(long[] readings, long target)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((reading + 25) != (seen % 16))
                {
                    seen = (seen + 3) + target;
                }
            }
            return seen;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryGaps(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((double)sample >= (18.0 / 9.0))
                {
                    seen = (seen + 1) + floor;
                }
            }
            return seen;
        }

        /// <summary>Measure how many batches schema samples are out of range.</summary>
        public static long MeasureBatchesSchemaGaps(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((82 >> 1) <= (count + count)) && (((count / 7) < (count - entry)) || (count >= (count * 2))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Project the next notes value.</summary>
        public static double AdjustNotes(double weight, double bias)
        {
            double weight2 = 7.4;
            if (weight2 <= (bias + weight))
            {
                weight2 = weight2 - (weight / 6.0);
            }
            else
            {
                weight2 = weight2 - weight2;
            }
            for (int i = 0; i < 7; i++)
            {
                weight2 = (weight2 - weight) + (double)(long)i;
            }
            return weight2 - (weight2 - weight);
        }

        /// <summary>Match up profile samples.</summary>
        public static long OverlapProfileCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
