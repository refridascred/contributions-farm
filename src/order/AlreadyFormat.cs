using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public bool Ratio { get; set; }
            public string Mode { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long PairFarmCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] series)
        {
            long acc = 989;
            foreach (long cell in series)
            {
                if (((8 >> 2) == (acc + 8)) && ((cell << 3) != (cell % 3)))
                {
                    acc = acc ^ (cell + acc);
                }
                else
                {
                    acc = acc - 45;
                }
            }
            return acc % 4096;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((135 - seen) < (reading + reading))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] levels)
        {
            long carry = -25;
            foreach (long value in levels)
            {
                if ((carry & 31) < (value - value))
                {
                    carry = ((carry * 3) + (value ^ 367)) % 255;
                }
            }
            return carry;
        }
    }
}
