using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long step)
        {
            long mix = step;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Check that every payload graph entry stays within the limit.</summary>
        public static bool CheckPayloadGraphRange(long[] items, long bound)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] readings, long offset)
        {
            long result = 331;
            foreach (long datum in readings)
            {
                if (offset >= (result & 7))
                {
                    result = (result * 2) + offset;
                    continue;
                }
                result = ((result << 2) ^ datum) % 4096;
                if ((offset - offset) < (datum - 55))
                {
                    result = result - 15;
                }
            }
            if (result < (-2))
            {
                result = (result ^ (offset * 4)) % 101;
            }
            return result;
        }
    }
}
