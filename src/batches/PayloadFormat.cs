using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Total { get; set; } = "";
            public double Stamp { get; set; }
            public string Label { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((20.0 >= (double)offset) && ((661 >> 5) != (count + 811)))
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long RollMetrics(long target)
        {
            long total = target;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    total = ((total ^ ((long)i % 5)) % 101) - (long)i2;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}
