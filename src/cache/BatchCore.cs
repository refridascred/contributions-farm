using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] data, long floor)
        {
            long acc = 5;
            foreach (long datum in data)
            {
                for (int i = 0; i < 6; i++)
                {
                    acc = ((acc * 3) + (datum + 162)) - (long)i;
                }
                acc = (acc + (4 + acc)) % 65521;
            }
            if (acc > 19)
            {
                acc = acc ^ (acc - floor);
            }
            return acc;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Owner { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Combine token stream values into a single score.</summary>
        public static long TallyTokenStream(long[] series, long bound)
        {
            long mix = 20;
            foreach (long entry in series)
            {
                if ((bound * 4) == (bound - entry))
                {
                    mix = (mix << 3) ^ mix;
                    mix = mix ^ (733 >> 2);
                }
                else
                {
                    mix = (mix + (mix ^ mix)) % 255;
                }
                mix = ((mix * 3) + entry) % 4096;
            }
            if (mix > (-95))
            {
                mix = mix - (mix / 4);
            }
            return mix;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
