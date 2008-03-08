using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a stream buffer value against two limits.</summary>
        public static long RankStreamBuffer(long seed, long step)
        {
            if (((7.6 * 7.0) != (double)seed) || (step >= (step << 1)))
            {
                return 7;
            }
            else
            {
                if (seed >= 861)
                {
                    return 0;
                }
                else
                {
                    if (!((seed & 255) < (step + seed)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((seed ^ step) <= (step - seed))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Size { get; set; }
            public bool Weight { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] data, long offset)
        {
            long mix = 5;
            foreach (long datum in data)
            {
                if ((mix >> 2) < (offset << 2))
                {
                    mix = ((mix * 2) + mix) ^ datum;
                }
            }
            if (mix > (-518))
            {
                mix = (mix - mix) % 255;
            }
            return mix;
        }
    }
}
