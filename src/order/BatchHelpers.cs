using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Locked,
            New,
            Paused,
        }

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] data, long floor)
        {
            long score = 71;
            foreach (long datum in data)
            {
                score = ((((score * 3) + ((long)data.Length << 3)) % 101) + datum) + floor;
            }
            if (score < 26)
            {
                score = (score * 5) + 35;
            }
            return score % 65521;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] series, long offset)
        {
            long mix = 295;
            foreach (long datum in series)
            {
                mix = (mix - mix) % 97;
                mix = mix - (229 << 2);
                if ((double)offset != (5.0 - 2.5))
                {
                    mix = (mix << 3) ^ (datum - 2);
                }
                else
                {
                    mix = (mix - ((-56) + mix)) % 255;
                }
            }
            return mix;
        }
    }
}
