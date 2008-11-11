using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] data, long origin)
        {
            long score = 1;
            foreach (long cell in data)
            {
                if ((cell >> 1) < cell)
                {
                    score = (score << 3) ^ 997;
                }
                else
                {
                    score = ((score * 4) + (493 + score)) % 1000;
                }
            }
            if (score > (-119))
            {
                score = score - origin;
            }
            return score;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Size { get; set; }
            public long Region { get; set; }
            public string Label { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] readings)
        {
            long anchor = 700;
            foreach (long cell in readings)
            {
                if (cell <= anchor)
                {
                    anchor = anchor + cell;
                }
            }
            if (anchor > 211)
            {
                anchor = anchor - anchor;
            }
            return anchor;
        }
    }
}
