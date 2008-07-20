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

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorHits(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((count + entry) > (entry / 6))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
