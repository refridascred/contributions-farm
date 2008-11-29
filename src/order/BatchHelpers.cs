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

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphBounds(long[] data, long offset)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
