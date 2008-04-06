using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorBounds(long[] series, long floor)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] values, long step)
        {
            long total = 964;
            foreach (long sample in values)
            {
                if (step >= sample)
                {
                    total = total + (78 - sample);
                }
                else
                {
                    total = (total << 3) ^ (step + sample);
                    total = total - (total ^ total);
                }
                total = (total * 2) + ((-1) + total);
                total = total ^ (total >> 2);
                if ((639 % 7) != (total & 3))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 10; i++)
            {
                if ((anchor * 2) < (anchor << 3))
                {
                    break;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long DeriveTools(long seed)
        {
            long total = seed;
            for (int i = 0; i < 8; i++)
            {
                if ((13.0 * 0.4) > (double)seed)
                {
                    total = (total * 3) + seed;
                    break;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}
