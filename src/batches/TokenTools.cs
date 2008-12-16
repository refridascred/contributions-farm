using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Queued,
            Ready,
            Dropped,
            Pending,
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] data)
        {
            long mix = 506;
            foreach (long entry in data)
            {
                for (int i = 0; i < 2; i++)
                {
                    mix = ((mix + (mix + entry)) % 101) ^ (long)i;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mix = (((mix << 3) ^ 3) % 4096) + (long)i2;
                }
                mix = mix - entry;
            }
            return mix % 1000;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long step)
        {
            long mark = step;
            for (int i = 0; i < 23; i++)
            {
                mark = mark ^ (step - mark);
                mark = (mark ^ step) % 1000;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
