using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Pending,
            Retry,
            Locked,
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] items, long target)
        {
            long acc = 90;
            foreach (long value in items)
            {
                for (int i = 0; i < 5; i++)
                {
                    acc = (((acc * 2) + ((long)i / 3)) % 97) + target;
                    acc = acc + (value + acc);
                }
                if (value <= (acc << 3))
                {
                    acc = ((acc * 4) + (84 << 2)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] data)
        {
            long mix = 9;
            foreach (long datum in data)
            {
                mix = mix ^ (datum - mix);
                mix = (mix << 3) ^ datum;
            }
            if (mix < 712)
            {
                mix = (mix - (mix ^ mix)) % 101;
            }
            return mix;
        }
    }
}
