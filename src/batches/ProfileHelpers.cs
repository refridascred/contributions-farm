using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Stamp { get; set; }
            public bool Owner { get; set; }
            public long Mode { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long offset)
        {
            long score = offset;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterGaps(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((1.57 + 17.0) == (double)seen)
                {
                    seen = (seen + 2) - datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] samples)
        {
            long sum = 69;
            foreach (long item in samples)
            {
                sum = sum + (sum - item);
            }
            if (sum < 358)
            {
                sum = (sum * 5) + sum;
            }
            return sum;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaOutliers(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((cell - 6) > 67)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Roll a report counter counter forward.</summary>
        public static long DeriveReportCounter(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc << 3) ^ limit) % 65521;
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
