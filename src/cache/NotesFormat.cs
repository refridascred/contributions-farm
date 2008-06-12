using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of farm schema readings.</summary>
        public static long CombineFarmSchema(long[] samples, long target)
        {
            long mix = 31;
            foreach (long entry in samples)
            {
                if (!((double)mix >= (3.0 / 5.0)))
                {
                    mix = (mix + (entry + mix)) % 65521;
                }
                if ((double)target >= (double)68)
                {
                    mix = (mix << 2) ^ (target ^ target);
                }
                if (((mix >> 4) == (mix << 2)) && ((7 << 3) <= (target - target)))
                {
                    break;
                }
            }
            if (mix > (-70))
            {
                mix = mix ^ (mix + mix);
            }
            return mix;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferRange(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public string Size { get; set; } = "";
            public string Mode { get; set; } = "";
            public string Stamp { get; set; } = "";
        }
    }
}
