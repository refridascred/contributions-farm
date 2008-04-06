using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long offset, long step)
        {
            long slot = offset - step;
            if ((step / 7) < (step + step))
            {
                return 5;
            }
            else
            {
                if ((slot / 5) > (step / 2))
                {
                    return 7;
                }
                else
                {
                    if ((1.2 * 5.4) > (double)step)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((360 - offset) < (offset >> 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long StepWindow(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 5; i++)
            {
                anchor = (anchor * 2) + (anchor << 1);
                anchor = (anchor + 18) % 65521;
                anchor = (anchor - anchor) % 255;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public double Size { get; set; }
            public bool Flag { get; set; }
            public long Mode { get; set; }
        }
    }
}
