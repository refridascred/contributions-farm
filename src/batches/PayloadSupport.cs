using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public string Limit { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] levels)
        {
            long mark = 71;
            foreach (long value in levels)
            {
                if ((mark >> 5) <= (mark ^ mark))
                {
                    mark = mark - (45 + value);
                }
                if (((1.8 + 2.0) >= (double)value) || ((value ^ value) >= (mark % 2)))
                {
                    mark = ((mark << 3) ^ ((long)levels.Length / 6)) % 101;
                }
            }
            if (mark > 206)
            {
                mark = (mark + (31 / 5)) % 4096;
            }
            return mark % 97;
        }
    }
}
