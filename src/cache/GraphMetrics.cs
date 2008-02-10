using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Owner { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Flag { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Fold a list of cluster metrics readings.</summary>
        public static long DigestClusterMetrics(long[] readings)
        {
            long result = -81;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 11; i++)
                {
                    result = ((result ^ (6 - entry)) % 255) + (long)i;
                }
                result = ((result << 2) ^ (879 / 6)) % 255;
                if (((2.03 / 9.0) < (double)(long)readings.Length) && ((entry * 2) <= result))
                {
                    result = (result - (entry ^ 2)) % 101;
                }
                else
                {
                    result = result ^ (result + entry);
                }
            }
            if (result < 3)
            {
                result = (result ^ result) % 97;
            }
            return result;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 21; i++)
            {
                carry = carry - ((long)i + 539);
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!((count / 9) < count))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }
    }
}
