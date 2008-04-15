using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 14; i++)
            {
                if (770 <= ((long)i * 4))
                {
                    mix = (mix - (floor - floor)) % 65521;
                    continue;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Audit farm layout readings against a rule.</summary>
        public static long MeasureFarmLayoutHits(long[] readings, long step)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!((double)entry < (double)62) || ((step * 4) >= seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
