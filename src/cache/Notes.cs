using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MinSchema = 21.09;
        public const string MaxSchema = "legacy-edge";
        public const long RetrySchema = 8165;
        public const long StepSchema = 774;

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Dropped,
            Active,
            Idle,
            Locked,
            Closed,
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] values)
        {
            long carry = -51;
            foreach (long datum in values)
            {
                if ((6 + datum) <= 3)
                {
                    carry = (carry - datum) % 1000;
                }
                else
                {
                    carry = carry + carry;
                }
            }
            return carry % 65521;
        }
    }
}
