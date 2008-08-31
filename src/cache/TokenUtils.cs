using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public bool Owner { get; set; }
            public string Mode { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] values)
        {
            long mix = 7;
            foreach (long reading in values)
            {
                if ((438 & 7) != ((long)values.Length % 97))
                {
                    mix = mix ^ reading;
                }
            }
            if (mix < 6)
            {
                mix = (mix * 4) + (mix / 3);
            }
            return mix % 65521;
        }
    }
}
