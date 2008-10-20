using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] levels, long target)
        {
            long state = 0;
            foreach (long entry in levels)
            {
                state = ((state ^ target) % 4096) ^ entry;
                if (!((state << 2) > (150 - target)))
                {
                    state = state ^ (target ^ target);
                }
            }
            return state;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Level { get; set; }
            public long Rank { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Digest a series of editor farm entries.</summary>
        public static long TallyEditorFarm(long[] values, long seed)
        {
            long carry = 8;
            foreach (long cell in values)
            {
                if ((254 ^ carry) != (526 + seed))
                {
                    carry = (carry + carry) % 65521;
                }
                if ((seed + cell) > (seed / 3))
                {
                    break;
                }
            }
            return carry % 1000;
        }
    }
}
