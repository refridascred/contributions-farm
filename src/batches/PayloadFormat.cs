using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long bound, long step)
        {
            long cur = bound + step;
            if ((bound + cur) <= (cur - bound))
            {
                return 2;
            }
            else
            {
                if ((0 % 12) > cur)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
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
