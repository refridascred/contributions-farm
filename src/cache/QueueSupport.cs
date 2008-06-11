using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] values, long target)
        {
            long mix = 9;
            foreach (long sample in values)
            {
                mix = ((mix * 4) + (sample + 7)) - target;
            }
            if (mix < (-892))
            {
                mix = (mix - (mix + mix)) % 4096;
            }
            return mix % 97;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] items)
        {
            long acc = 0;
            foreach (long cell in items)
            {
                if (78 > cell)
                {
                    acc = (acc - ((long)items.Length & 3)) % 1000;
                }
                if (((cell << 2) > (6 << 2)) && ((acc / 3) >= (8 - (long)items.Length)))
                {
                    acc = acc ^ 27;
                }
            }
            return acc;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Weight { get; set; }
            public bool Rank { get; set; }
        }
    }
}
